using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Wallet
{
    public partial class Form7 : Form
    {
        string connectionString =
            @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";

        private string userEmail;

        public Form7(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadCourses();
            btnConfirm.Enabled = false;
        }
        private void LoadCourses()
        {
            string query = "SELECT course_id, course_name FROM Course";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCourses.DataSource = dt;
                cmbCourses.DisplayMember = "course_name";
                cmbCourses.ValueMember = "course_id";
            }
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedValue == null)
                return;

            if (int.TryParse(cmbCourses.SelectedValue.ToString(), out int courseId))
            {
                LoadCourseDetails(courseId);
                btnConfirm.Enabled = true;
            }
        }

        private void LoadCourseDetails(int courseId)
        {
            string query = @"SELECT instructor, preRequisite, coinRequired, maxCapacity
                             FROM Course
                             WHERE course_id = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", courseId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cmbInstructors.Items.Clear();
                    if (reader["instructor"] != DBNull.Value)
                    {
                        cmbInstructors.Items.Add(reader["instructor"].ToString());
                        cmbInstructors.SelectedIndex = 0;
                    }

                    txtPreRequisite.Text =
                        reader["preRequisite"] == DBNull.Value
                        ? "None"
                        : reader["preRequisite"].ToString();

                    txtCoinsRequired.Text = reader["coinRequired"].ToString();
                    txtMaxCapacity.Text = reader["maxCapacity"].ToString();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(cmbCourses.SelectedValue);

            if (!HasCompletedPrerequisite(courseId))
            {
                MessageBox.Show("Prerequisite course not completed!");
                return;
            }

            if (!HasEnoughCoins())
            {
                MessageBox.Show("You do not have enough coins!");
                return;
            }

            if (!HasAvailableCapacity(courseId))
            {
                MessageBox.Show("Course is already full!");
                return;
            }

            EnrollCourse(courseId);
            MessageBox.Show("Course enrolled successfully!");
            LoadCourses();

        }

        private bool HasCompletedPrerequisite(int courseId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string preQuery =
                    "SELECT preRequisite FROM Course WHERE course_id = @id";

                SqlCommand preCmd = new SqlCommand(preQuery, conn);
                preCmd.Parameters.AddWithValue("@id", courseId);

                string prerequisite = preCmd.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(prerequisite) || prerequisite == "None")
                    return true;

                string checkQuery = @"
                    SELECT COUNT(*) FROM Enrollment E
                    JOIN Course C ON E.course_id = C.course_id
                    WHERE E.learner_email = @email
                    AND C.course_name = @pre";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@email", userEmail);
                checkCmd.Parameters.AddWithValue("@pre", prerequisite);

                int count = (int)checkCmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool HasEnoughCoins()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT coin FROM Users WHERE email = @email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", userEmail);

                int coins = (int)cmd.ExecuteScalar();
                return coins >= 20;
            }
        }

        private bool HasAvailableCapacity(int courseId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "SELECT maxCapacity FROM Course WHERE course_id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", courseId);

                int capacity = (int)cmd.ExecuteScalar();
                return capacity > 0;
            }
        }

        private void EnrollCourse(int courseId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tr = conn.BeginTransaction();

                try
                {
                    string enrollQuery = @"
                        INSERT INTO Enrollment (learner_email, course_id, instructor)
                        VALUES (@email, @course, @inst)";

                    SqlCommand enrollCmd =
                        new SqlCommand(enrollQuery, conn, tr);

                    enrollCmd.Parameters.AddWithValue("@email", userEmail);
                    enrollCmd.Parameters.AddWithValue("@course", courseId);
                    enrollCmd.Parameters.AddWithValue("@inst", cmbInstructors.Text);
                    enrollCmd.ExecuteNonQuery();

                    string coinQuery =
                        "UPDATE Users SET coin = coin - 20 WHERE email = @email";

                    SqlCommand coinCmd =
                        new SqlCommand(coinQuery, conn, tr);

                    coinCmd.Parameters.AddWithValue("@email", userEmail);
                    coinCmd.ExecuteNonQuery();

                    string capQuery =
                        "UPDATE Course SET maxCapacity = maxCapacity - 1 WHERE course_id = @id";

                    SqlCommand capCmd =
                        new SqlCommand(capQuery, conn, tr);

                    capCmd.Parameters.AddWithValue("@id", courseId);
                    capCmd.ExecuteNonQuery();

                    tr.Commit();
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("Enrollment failed!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form6 learnerForm = new Form6(userEmail);
            learnerForm.Show();
            this.Hide();
        }
    }
}
