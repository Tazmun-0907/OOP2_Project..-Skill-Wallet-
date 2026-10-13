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
    public partial class Dashboard : Form
    {
        string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";
        private string userEmail;
        private string fullName;
        public Dashboard(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            string query = "SELECT First_name, Last_name, email FROM Users WHERE email = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fname = reader["First_name"].ToString();
                                string lname = reader["Last_name"].ToString();

                                fullName = fname + " " + lname;

                                lblHello.Text = "Hello, " + fullName;
                                lblRoleText.Text = "Continuing today as:";

                                lblProfileName.Text = fullName;
                                lblProfileEmail.Text = reader["email"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found in database.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user: " + ex.Message);
                }
            }
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            Form5 instructorForm = new Form5(userEmail);
            instructorForm.Show();
            this.Hide();
        }

        private void btnLearner_Click(object sender, EventArgs e)
        {
            Form6 learnerForm = new Form6(userEmail);
            learnerForm.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = !pnlProfile.Visible;
        }

        private void btnCoins_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coins page coming soon!");
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Courses page coming soon!");
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Community page coming soon!");
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jobs page coming soon!");
        }

        private void btnUniversity_Click(object sender, EventArgs e)
        {
            MessageBox.Show("University page coming soon!");
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Profile form coming soon!");
            // Future:
            // UpdateProfile up = new UpdateProfile(userEmail);
            // up.Show();
            // this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }
    }
}
