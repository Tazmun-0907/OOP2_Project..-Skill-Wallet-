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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstName == null || txtEmail == null || cmbNationality == null)
            {
                MessageBox.Show("UI Controls are not properly initialized.");
                return;
            }

            // 2. Validate empty strings
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("First Name and Email are required.");
                return;
            }
            string connectionString = @"Data Source=DESKTOP-CIQ9AKI\SQLEXPRESS;Initial Catalog=SkillWallet;Integrated Security=True";
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string dob = dtpBirthDate.Value.ToString("yyyy-MM-dd"); // Format for SQL
            string email = txtEmail.Text;
            string nationality = cmbNationality.SelectedItem?.ToString();

            // Get Radio Button value for Gender
            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "Others";

            // 2. SQL Query (Using Parameters to prevent SQL Injection)
            string query = "INSERT INTO Users (First_name, Last_name, Date_of_birth, Gender, Nationality, email) " +
                "VALUES (@fname, @lname, @dob, @gender, @nat, @email)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 3. Bind Parameters
                        cmd.Parameters.AddWithValue("@fname", firstName);
                        cmd.Parameters.AddWithValue("@lname", lastName);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@nat", nationality ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", email);

                        // 4. Execute
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully!");
                        this.Hide();
                        Form3 f3 = new Form3(email);
                        f3.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
