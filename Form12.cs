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
    public partial class Form12 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";
        private string userEmail;

        public Form12(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query =
                        "SELECT community_ID AS [ID], community_Title AS [Community Title] FROM community";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textJoin.Text.Trim(), out int id))
            {
                MessageBox.Show("Invalid Community ID!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM community WHERE community_ID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Successfully Joined!");
                    textJoin.Clear();
                    textJoin.Focus();
                }
                else
                {
                    MessageBox.Show("Community ID not found!");
                }
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textLeave.Text.Trim(), out int id))
            {
                MessageBox.Show("Invalid Community ID!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "DELETE FROM community WHERE community_ID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Successfully Left!");
                    textLeave.Clear();
                    textLeave.Focus();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Community ID not found!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(userEmail);
            f10.Show();
            this.Close();
        }
    }
}
