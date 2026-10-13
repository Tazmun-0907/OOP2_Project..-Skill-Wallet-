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
    public partial class Form9 : Form
    {
        string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";
        private string userEmail;

        public Form9(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadJobIDs();
        }

        private void LoadJobIDs()
        {
            string query = "SELECT job_ID FROM Job";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbJobID.DataSource = null;   
                cmbJobID.DisplayMember = "job_ID";
                cmbJobID.ValueMember = "job_ID";
                cmbJobID.DataSource = dt;
            }
        }

        private void cmbJobID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJobID.SelectedValue == null)
                return;

            if (int.TryParse(cmbJobID.SelectedValue.ToString(), out int jobId))
            {
                LoadJobDetails(jobId);
            }
        }

        private void LoadJobDetails(int jobId)
        {
            string query = @"SELECT post_Name, coin_requirements, course_requirements
                             FROM Job
                             WHERE job_ID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", jobId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtPostName.Text = reader["post_Name"].ToString();
                        txtCoinRequired.Text = reader["coin_requirements"].ToString();
                        txtCourseRequired.Text = reader["course_requirements"].ToString();
                    }
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
