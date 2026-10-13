using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Wallet
{
    public partial class Form6 : Form
    {
        private string userEmail;
        private int coins = 100;   

        public Form6(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Coin meter text only
            lblCoins.Text = "Coins: " + coins;
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            try
            {
                Form7 courseForm = new Form7(userEmail);
                courseForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Course form: " + ex.Message);
            }
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            Form10 communityForm = new Form10(userEmail);
            communityForm.Show();
            this.Hide();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            Form9 jobForm = new Form9(userEmail);
            jobForm.Show();
            this.Hide();
        }

        private void btnUniversity_Click(object sender, EventArgs e)
        {
            Form8 universityForm = new Form8(userEmail);
            universityForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userEmail);
            dashboard.Show();
            this.Hide();
        }
    }
}
