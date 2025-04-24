using System;
using System.Data;
using System.Text.RegularExpressions; 
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PetPals
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            

            // Set fixed size
            this.Size = new Size(1000, 800);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Open at center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public void connectdb()
        {
            String oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!IsValidEmail(textBox1.Text))
            {
                textBox1.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
            }



        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connectdb();

                // Step 1: Check if email exists and get password hash + role
                string query = "SELECT PasswordHash, Role FROM Users WHERE EmailID = :email";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();
                    string role = reader["Role"].ToString();

                    var passwordHasher = new Microsoft.AspNetCore.Identity.PasswordHasher<object>();
                    var result = passwordHasher.VerifyHashedPassword(null, storedHash, password);

                    if (result == Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success)
                    {
                        MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Step 2: Fetch user details
                        string userDetailsQuery = @"SELECT UserID, FullName, EmailID, PasswordHash, PhoneNumber, Address
                            FROM Users WHERE EmailID = :email";

                        OracleCommand detailsCmd = new OracleCommand(userDetailsQuery, conn);
                        detailsCmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

                        OracleDataReader detailsReader = detailsCmd.ExecuteReader();

                        UserInfo userInfo = new UserInfo();

                        if (detailsReader.Read())
                        {
                            userInfo.UserID = Convert.ToInt32(detailsReader["UserID"]); // ? Add this line
                            userInfo.FullName = detailsReader["FullName"].ToString();
                            userInfo.EmailID = detailsReader["EmailID"].ToString();
                            userInfo.Password = password;
                            userInfo.PhoneNumber = detailsReader["PhoneNumber"].ToString();
                            userInfo.Address = detailsReader["Address"].ToString();
                        }


                        Form nextForm = null;

                        // Step 3: Open form based on role and pass userInfo where needed
                        switch (role)
                        {
                            case "Admin":
                                nextForm = new Form3();
                                break;
                            case "FosterParent":
                             //
                                break;
                            case "Adopter":
                                nextForm = new Form5(userInfo);
                                break;
                            case "ShelterStaff":
                                nextForm = new Form7(userInfo);
                                break;
                            default:
                                MessageBox.Show("Unknown role: " + role,
                                                "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }

                        this.Hide();
                        nextForm.FormClosed += (s, args) => this.Close();
                        nextForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No account found with that email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
