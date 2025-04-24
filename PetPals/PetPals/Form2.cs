using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace PetPals
{
    public partial class Form2 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form2()
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
            MessageBox.Show("Connection Succeeded");
        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adopter");
            comboBox1.Items.Add("FosterParent");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("ShelterStaff");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox2.Text))
            {
                textBox2.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            string phoneNumber = textBox1.Text;

            // Email validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                textBox2.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                textBox2.BackColor = Color.White;
            }

            // Phone number validation (only digits and 10 characters long)
            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.",
                                "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }

            // Check if any required field is missing
            if (string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||  // Password
                string.IsNullOrWhiteSpace(textBox4.Text) ||  // Full Name
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textBox6.Text))    // Address
            {
                MessageBox.Show("Please fill in all fields before registering.",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connectdb();

            try
            {
                // Check if email already exists
                string emailCheckQuery = "SELECT COUNT(*) FROM Users WHERE EmailID = :email";
                OracleCommand checkCmd = new OracleCommand(emailCheckQuery, conn);
                checkCmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("This email is already registered.",
                                    "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generate a unique user ID (e.g., using a sequence or max + 1 logic)
                string getIdQuery = "SELECT NVL(MAX(UserID), 0) + 1 FROM Users";
                OracleCommand idCmd = new OracleCommand(getIdQuery, conn);
                int newUserId = Convert.ToInt32(idCmd.ExecuteScalar());

                // Hash the password securely
                var passwordHasher = new Microsoft.AspNetCore.Identity.PasswordHasher<object>();
                string hashedPassword = passwordHasher.HashPassword(null, textBox3.Text);

                // Insert user into database
                string query = @"INSERT INTO Users 
                         (UserID, FullName, PasswordHash, Role, PhoneNumber, Address, EmailID)
                         VALUES (:UserID, :FullName, :PasswordHash, :Role, :PhoneNumber, :Address, :EmailID)";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("UserID", OracleDbType.Int32).Value = newUserId;
                cmd.Parameters.Add("FullName", OracleDbType.Varchar2).Value = textBox4.Text;
                cmd.Parameters.Add("PasswordHash", OracleDbType.Varchar2).Value = hashedPassword;
                cmd.Parameters.Add("Role", OracleDbType.Varchar2).Value = comboBox1.SelectedItem.ToString();
                cmd.Parameters.Add("PhoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = textBox6.Text;
                cmd.Parameters.Add("EmailID", OracleDbType.Varchar2).Value = email;

                cmd.ExecuteNonQuery();

                MessageBox.Show("User inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
