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

namespace PetPals
{
    public partial class Form9 : Form
    {
        private UserInfo currentUser;

        public Form9(UserInfo userInfo)
        {
            InitializeComponent();
            currentUser = userInfo;
            // Set fixed size
            this.Size = new Size(800, 600);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Open at center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a rating.");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Please enter your comments.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPetID.Text))
            {
                MessageBox.Show("Please enter the Pet ID.");
                return;
            }

            int petID;
            if (!int.TryParse(textBoxPetID.Text, out petID))
            {
                MessageBox.Show("Invalid Pet ID.");
                return;
            }

            try
            {
                string oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin";
                using (OracleConnection conn = new OracleConnection(oradb))
                {
                    conn.Open();

                    // Get next ReviewID
                    OracleCommand getIDCmd = new OracleCommand("SELECT NVL(MAX(ReviewID), 0) + 1 FROM Reviews", conn);
                    int newReviewID = Convert.ToInt32(getIDCmd.ExecuteScalar());

                    // Insert Review
                    OracleCommand insertCmd = new OracleCommand("INSERT INTO Reviews (ReviewID, UserID, PetID, Rating, Comments, ReviewDate) VALUES (:reviewID, :userID, :petID, :rating, :comments, :reviewDate)", conn);
                    insertCmd.Parameters.Add("reviewID", newReviewID);
                    insertCmd.Parameters.Add("userID", currentUser.UserID);
                    insertCmd.Parameters.Add("petID", petID);
                    insertCmd.Parameters.Add("rating", Convert.ToInt32(comboBox1.SelectedItem));
                    insertCmd.Parameters.Add("comments", richTextBox1.Text.Trim());
                    insertCmd.Parameters.Add("reviewDate", DateTime.Today);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Thank you for your submission. We value your response.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting review: " + ex.Message);
            }
        }
    }
}
