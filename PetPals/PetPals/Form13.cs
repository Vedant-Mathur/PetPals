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
    public partial class Form13 : Form
    {
        public Form13()
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

                    // 1. Get PetID and UserID from AdoptionRequests
                    OracleCommand getRequestCmd = new OracleCommand("SELECT PetID, UserID FROM AdoptionRequests WHERE RequestID = :requestID", conn);
                    getRequestCmd.Parameters.Add("requestID", requestID);

                    OracleDataReader reader = getRequestCmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("No adoption request found for this Request ID.");
                        return;
                    }

                    int petID = reader.GetInt32(0);
                    int userID = reader.GetInt32(1);
                    reader.Close();

                    // 2. Update the AdoptionRequests status
                    OracleCommand updateRequestCmd = new OracleCommand("UPDATE AdoptionRequests SET Status = :status WHERE RequestID = :requestID", conn);
                    updateRequestCmd.Parameters.Add("status", selectedStatus);
                    updateRequestCmd.Parameters.Add("requestID", requestID);
                    updateRequestCmd.ExecuteNonQuery();

                    // 3. If Approved, update Pets and insert into AdoptionRecords
                    if (selectedStatus == "Approved")
                    {
                        // Update Pet status
                        OracleCommand updatePetCmd = new OracleCommand("UPDATE Pets SET Status = 'Adopted' WHERE PetID = :petID", conn);
                        updatePetCmd.Parameters.Add("petID", petID);
                        updatePetCmd.ExecuteNonQuery();

                        // Insert into AdoptionRecords
                        int adoptionID = GetNextID(conn, "AdoptionRecords", "AdoptionID");
                        DateTime today = DateTime.Today;
                        DateTime followUp = today.AddDays(30);

                        OracleCommand insertAdoptionCmd = new OracleCommand("INSERT INTO AdoptionRecords (AdoptionID, PetID, UserID, AdoptionDate, FollowUpDate) VALUES (:adoptionID, :petID, :userID, :adoptionDate, :followUpDate)", conn);
                        insertAdoptionCmd.Parameters.Add("adoptionID", adoptionID);
                        insertAdoptionCmd.Parameters.Add("petID", petID);
                        insertAdoptionCmd.Parameters.Add("userID", userID);
                        insertAdoptionCmd.Parameters.Add("adoptionDate", today);
                        insertAdoptionCmd.Parameters.Add("followUpDate", followUp);
                        insertAdoptionCmd.ExecuteNonQuery();
                    }

                    txn.Commit();
                    MessageBox.Show($"Request status updated to {selectedStatus}.");

                    // Refresh grid
                    Form13_Load(null, null);

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


        private void Form13_Load(object sender, EventArgs e)
        {
            string oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            using (OracleConnection conn = new OracleConnection(oradb))
            {
                try
                {
                    conn.Open();

                    string query = @"
            SELECT ar.RequestID, ar.PetID, u.FullName, ar.RequestDate, ar.Status 
            FROM AdoptionRequests ar
            JOIN Users u ON ar.UserID = u.UserID
            WHERE ar.Status = 'Pending'";

                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load pending requests: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
