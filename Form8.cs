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
    public partial class Form8 : Form
    {
        string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";

        private string userEmail;
        private int userCoins;
        public Form8(string email)
        {
            InitializeComponent();
            userEmail = email;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            LoadUniversityIDs();
        }

        /*private void LoadUserCoins()
        {
            string query = "SELECT coin FROM Users WHERE email = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", userEmail);

                conn.Open();

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt); 
                }

                if (dt.Rows.Count > 0 && dt.Rows[0]["coin"] != DBNull.Value)
                {
                    userCoins = Convert.ToInt32(dt.Rows[0]["coin"]);
                }
                else
                {
                    userCoins = 0;
                }
            }
        }*/



        private void LoadUniversityIDs()
        {
            string query = "SELECT university_ID FROM University";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbUniversityID.DataSource = null; 
                cmbUniversityID.DisplayMember = "university_ID";
                cmbUniversityID.ValueMember = "university_ID";
                cmbUniversityID.DataSource = dt;
            }
        }

        private void cmbUniversityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUniversityID.SelectedValue == null)
                return;

            if (int.TryParse(cmbUniversityID.SelectedValue.ToString(), out int universityId))
            {
                LoadUniversityDetails(universityId);
            }
        }
        private void LoadUniversityDetails(int universityId)
        {
            string query = @"SELECT universityName, waiver
                             FROM University
                             WHERE university_ID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", universityId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtUniversityName.Text = reader["universityName"].ToString();
                        txtWaiver.Text = reader["waiver"].ToString();
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
