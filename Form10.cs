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
    public partial class Form10 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";
        private string userEmail;

        public Form10(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCommunityID.Text) ||
                string.IsNullOrWhiteSpace(txtCommunityTitle.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string checkQuery =
                        "SELECT COUNT(*) FROM community WHERE community_ID = @id";

                    SqlCommand cmdCheck = new SqlCommand(checkQuery, con);
                    cmdCheck.Parameters.AddWithValue("@id",
                        int.Parse(txtCommunityID.Text.Trim()));

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This Community ID already exists!");
                        return;
                    }

                    string insertQuery =
                        "INSERT INTO community (community_ID, community_Title) VALUES (@id, @title)";

                    SqlCommand cmdInsert = new SqlCommand(insertQuery, con);
                    cmdInsert.Parameters.AddWithValue("@id",
                        int.Parse(txtCommunityID.Text.Trim()));
                    cmdInsert.Parameters.AddWithValue("@title",
                        txtCommunityTitle.Text.Trim());

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Community Saved Successfully!");

                    Form11 f11 = new Form11(userEmail);
                    f11.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void btnExistingCommunity_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(userEmail);
            f12.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form6 learnerForm = new Form6(userEmail);
            learnerForm.Show();
            this.Hide();
        }
    }
}
