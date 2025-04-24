using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PetPals
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a Request ID.");
                return;
            }

            string selectedStatus = null;
            if (radioButton1.Checked)
                selectedStatus = "Pending";
            else if (radioButton2.Checked)
                selectedStatus = "Approved";
            else if (radioButton3.Checked)
                selectedStatus = "Rejected";
            else
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            int requestID;
            if (!int.TryParse(textBox1.Text, out requestID))
            {
                MessageBox.Show("Invalid Request ID.");
                return;
            }

            string oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            using (OracleConnection conn = new OracleConnection(oradb))
            {
                try
                {
                    conn.Open();
                    OracleTransaction txn = conn.BeginTransaction();

                    // 1. Get PetID and UserID from FosterRequests
                    OracleCommand getRequestCmd = new OracleCommand("SELECT PetID, UserID FROM FosterRequests WHERE RequestID = :requestID", conn);
                    getRequestCmd.Parameters.Add("requestID", requestID);

                    OracleDataReader reader = getRequestCmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("No foster request found for this Request ID.");
                        return;
                    }

                    int petID = reader.GetInt32(0);
                    int userID = reader.GetInt32(1);
                    reader.Close();

                    // 2. Update the FosterRequests status
                    OracleCommand updateRequestCmd = new OracleCommand("UPDATE FosterRequests SET Status = :status WHERE RequestID = :requestID", conn);
                    updateRequestCmd.Parameters.Add("status", selectedStatus);
                    updateRequestCmd.Parameters.Add("requestID", requestID);
                    updateRequestCmd.ExecuteNonQuery();

                    // 3. If Approved, insert into FosterCare
                    if (selectedStatus == "Approved")
                    {
                        DateTime fosterDate = DateTime.Today; // Set the start date as today
                        DateTime returnDate = fosterDate.AddMonths(1); // Assuming 1 month as a default return period, you can adjust this logic

                        // Insert into FosterCare table
                        OracleCommand insertCareCmd = new OracleCommand("INSERT INTO FosterCare (FosterID, PetID, UserID, StartDate, EndDate) VALUES (:fosterID, :petID, :userID, :startDate, :endDate)", conn);
                        int fosterID = GetNextID(conn, "FosterCare", "FosterID");
                        insertCareCmd.Parameters.Add("fosterID", fosterID);
                        insertCareCmd.Parameters.Add("petID", petID);
                        insertCareCmd.Parameters.Add("userID", userID);
                        insertCareCmd.Parameters.Add("startDate", fosterDate);
                        insertCareCmd.Parameters.Add("endDate", returnDate);
                        insertCareCmd.ExecuteNonQuery();
                    }

                    txn.Commit();
                    MessageBox.Show($"Request status updated to {selectedStatus}.");

                    // Refresh grid
                    Form15_Load(null, null);

                    // Clear input
                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private int GetNextID(OracleConnection conn, string table, string column)
        {
            OracleCommand cmd = new OracleCommand($"SELECT NVL(MAX({column}), 0) + 1 FROM {table}", conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            string oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            using (OracleConnection conn = new OracleConnection(oradb))
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT fr.RequestID, fr.PetID, u.FullName, fr.RequestDate, fr.Status 
                    FROM FOSTERREQUESTS fr
                    JOIN USERS u ON fr.UserID = u.UserID
                    WHERE fr.Status = 'Pending'";

                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load pending foster requests: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add code here if you need to handle text changes.
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Nothing here for now
        }

    }
}
