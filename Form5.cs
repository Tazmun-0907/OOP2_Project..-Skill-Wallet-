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
    public partial class Form5 : Form
    {
        private string userEmail;
        //private int coins = 120; 

        string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";
        public Form5(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadCourses();
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
        }
        private void LoadCourses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT course_name FROM Course";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cmbCourses.Items.Clear();

                while (reader.Read())
                {
                    cmbCourses.Items.Add(reader["course_name"].ToString());
                }

                if (cmbCourses.Items.Count > 0)
                    cmbCourses.SelectedIndex = 0;
            }
        }

        private void btnUploadVideo_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }

            openFileDialog1.Filter = "Video Files|*.mp4;*.avi;*.mkv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AssignInstructorToCourse();
                MessageBox.Show("Video uploaded and instructor assigned successfully!");
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMeetLink.Text))
            {
                MessageBox.Show("Please enter Google Meet link.");
                return;
            }

            AssignInstructorToCourse();
            MessageBox.Show("Live class scheduled successfully!");
        }

        private void AssignInstructorToCourse()
        {
            string instructorName = GetInstructorName();
            string selectedCourse = cmbCourses.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    @"UPDATE Course 
                      SET instructor = @inst 
                      WHERE course_name = @course AND instructor IS NULL";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@inst", instructorName);
                cmd.Parameters.AddWithValue("@course", selectedCourse);

                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                {
                    MessageBox.Show("This course already has an instructor assigned.");
                }
            }
        }

        private string GetInstructorName()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "SELECT First_name, Last_name FROM Users WHERE email = @email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", userEmail);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return reader["First_name"] + " " + reader["Last_name"];
                }
            }

            return "Unknown Instructor";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userEmail);
            dashboard.Show();
            this.Hide();
        }
    }
}
