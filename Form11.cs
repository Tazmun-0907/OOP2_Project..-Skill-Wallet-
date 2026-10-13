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
    public partial class Form11 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";
        private string userEmail;

        public Form11(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void Form11_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt1.Text))
            {
                MessageBox.Show("Please enter an ID or Name to search.");
                LoadData();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query =
                        @"SELECT community_ID AS [ID], community_Title AS [Community Title]
                          FROM community
                          WHERE CAST(community_ID AS VARCHAR) LIKE @search
                          OR community_Title LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + txt1.Text.Trim() + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No match found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Error: " + ex.Message);
                }
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(userEmail);
            f10.Show();
            this.Hide();
        }
    }
}
