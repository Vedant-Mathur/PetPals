using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetPals
{
    public partial class Form8 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public void connectdb()
        {
            String oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True ";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        public Form8()
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

        private UserInfo currentUser; // store the user

        public Form8(UserInfo userInfo)
        {
            InitializeComponent();
            currentUser = userInfo;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.ClientSize = new Size(800, 600);

            // Fill textboxes
            textBox1.Text = userInfo.FullName;
            textBox2.Text = userInfo.Password;
            textBox3.Text = userInfo.EmailID;
            textBox4.Text = userInfo.PhoneNumber;
            textBox5.Text = userInfo.Address;
            label7.Text = userInfo.UserID.ToString();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connectdb();

                string updatedFullName = textBox1.Text.Trim();
                string updatedPassword = textBox2.Text;
                string updatedEmail = textBox3.Text.Trim();
                string updatedPhone = textBox4.Text.Trim();
                string updatedAddress = textBox5.Text.Trim();

                // Step 1: Check for email conflict if email was changed
                if (!string.Equals(updatedEmail, currentUser.EmailID, StringComparison.OrdinalIgnoreCase))
                {
                    string emailCheckQuery = "SELECT COUNT(*) FROM Users WHERE EmailID = :email";
                    OracleCommand emailCmd = new OracleCommand(emailCheckQuery, conn);
                    emailCmd.Parameters.Add("email", OracleDbType.Varchar2).Value = updatedEmail;

                    int count = Convert.ToInt32(emailCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("This email is already associated with another account.",
                                        "Email Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Step 2: Prepare new values — only update if the field is changed
                var passwordHasher = new Microsoft.AspNetCore.Identity.PasswordHasher<object>();
                string hashedPassword = string.Equals(updatedPassword, currentUser.Password) ? null : passwordHasher.HashPassword(null, updatedPassword);

                string updateQuery = "UPDATE Users SET ";
                List<string> updates = new List<string>();
                var parameters = new List<OracleParameter>();

                if (updatedFullName != currentUser.FullName)
                {
                    updates.Add("FullName = :fullName");
                    parameters.Add(new OracleParameter("fullName", updatedFullName));
                }
                if (hashedPassword != null)
                {
                    updates.Add("PasswordHash = :passwordHash");
                    parameters.Add(new OracleParameter("passwordHash", hashedPassword));
                }
                if (updatedEmail != currentUser.EmailID)
                {
                    updates.Add("EmailID = :email");
                    parameters.Add(new OracleParameter("email", updatedEmail));
                }
                if (updatedPhone != currentUser.PhoneNumber)
                {
                    updates.Add("PhoneNumber = :phone");
                    parameters.Add(new OracleParameter("phone", updatedPhone));
                }
                if (updatedAddress != currentUser.Address)
                {
                    updates.Add("Address = :address");
                    parameters.Add(new OracleParameter("address", updatedAddress));
                }

                if (updates.Count == 0)
                {
                    MessageBox.Show("No changes detected.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                updateQuery += string.Join(", ", updates) + " WHERE UserID = :userId";
                parameters.Add(new OracleParameter("userId", currentUser.UserID));

                OracleCommand updateCmd = new OracleCommand(updateQuery, conn);
                updateCmd.Parameters.AddRange(parameters.ToArray());

                int rowsUpdated = updateCmd.ExecuteNonQuery();

                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Profile successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update local user info
                    currentUser.FullName = updatedFullName;
                    currentUser.Password = updatedPassword;
                    currentUser.EmailID = updatedEmail;
                    currentUser.PhoneNumber = updatedPhone;
                    currentUser.Address = updatedAddress;
                }
                else
                {
                    MessageBox.Show("No rows were updated.", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
