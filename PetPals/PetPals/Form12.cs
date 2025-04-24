using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetPals
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
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
            try
            {
                // Check if input is valid
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter a valid Pet ID.");
                    return;
                }

                int petId;
                if (!int.TryParse(textBox1.Text, out petId))
                {
                    MessageBox.Show("Pet ID must be a number.");
                    return;
                }

                // Confirm delete
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this pet?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                    return;

                // Oracle connection string
                string oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";

                using (OracleConnection conn = new OracleConnection(oradb))
                {
                    conn.Open();

                    // Check if pet exists
                    string checkQuery = "SELECT COUNT(*) FROM Pets WHERE PetID = :petId";
                    using (OracleCommand checkCmd = new OracleCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.Add(":petId", OracleDbType.Int32).Value = petId;

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("No pet found with that ID.");
                            return;
                        }
                    }

                    // Delete pet
                    string deleteQuery = "DELETE FROM Pets WHERE PetID = :petId";
                    using (OracleCommand deleteCmd = new OracleCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.Add(":petId", OracleDbType.Int32).Value = petId;

                        int rowsDeleted = deleteCmd.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                            MessageBox.Show("Pet deleted successfully from the database.");
                        else
                            MessageBox.Show("Failed to delete the pet.");
                    }

                    conn.Close();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting pet: " + ex.Message);
            }
        }


        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
