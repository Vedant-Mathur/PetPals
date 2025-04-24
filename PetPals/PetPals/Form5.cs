using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace PetPals
{
    public partial class Form5 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;

        private UserInfo currentUser;

        private Dictionary<string, List<string>> animalBreeds = new Dictionary<string, List<string>>()
        {
            { "dog", new List<string> { "Labrador", "German Shepherd", "Golden Retriever", "Poodle" } },
            { "cat", new List<string> { "Persian", "Siamese", "Maine Coon", "Bengal" } },
            { "bird", new List<string> { "Parrot", "Canary", "Sparrow", "Macaw" } },
            { "fish", new List<string> { "Goldfish", "Betta", "Guppy", "Angelfish" } }
        };

        public Form5(UserInfo userInfo)
        {
            InitializeComponent();

            // Set fixed size
            this.Size = new Size(1000, 800);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Open at center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

            currentUser = userInfo;
        }

        public Form5()
        {
            InitializeComponent();
        }

        public void connectdb()
        {
            string oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(animalBreeds.Keys.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAnimal = comboBox1.SelectedItem.ToString();
            LoadAvailablePetsBySpecies(selectedAnimal);
        }

        private void LoadAvailablePetsBySpecies(string species)
        {
            try
            {
                connectdb();

                string query = "SELECT * FROM Pets WHERE Species = :species AND Status = 'Available'";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("species", OracleDbType.Varchar2).Value = species;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching pet data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a Pet ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connectdb();

                int petID = int.Parse(textBox1.Text);
                int userID = currentUser.UserID;
                int requestID = GetNextID("AdoptionRequests", "RequestID");
                DateTime today = DateTime.Today;

                // Check if pet exists and is available
                OracleCommand checkCmd = new OracleCommand("SELECT Status FROM Pets WHERE PetID = :petID", conn);
                checkCmd.Parameters.Add("petID", petID);
                string status = Convert.ToString(checkCmd.ExecuteScalar());

                if (status != "Available")
                {
                    MessageBox.Show("This pet is not available for adoption.");
                    return;
                }

                // Increment inquiries count in Pets table
                OracleCommand updateInquiryCmd = new OracleCommand(
                    "UPDATE Pets SET Inquiries = NVL(Inquiries, 0) + 1 WHERE PetID = :petID", conn);
                updateInquiryCmd.Parameters.Add("petID", petID);
                updateInquiryCmd.ExecuteNonQuery();

                // Increment inquiries count in Analytics table (assuming it has a PetID and Inquiries column)
                OracleCommand updateAnalyticsCmd = new OracleCommand(
                    "UPDATE Analytics SET Inquiries = NVL(Inquiries, 0) + 1 WHERE PetID = :petID", conn);
                updateAnalyticsCmd.Parameters.Add("petID", petID);
                updateAnalyticsCmd.ExecuteNonQuery();

                // Insert adoption request with 'Pending' status
                OracleCommand insertCmd = new OracleCommand(
                    "INSERT INTO AdoptionRequests (RequestID, PetID, UserID, RequestDate, Status) VALUES (:requestID, :petID, :userID, :requestDate, 'Pending')", conn);
                insertCmd.Parameters.Add("requestID", requestID);
                insertCmd.Parameters.Add("petID", petID);
                insertCmd.Parameters.Add("userID", userID);
                insertCmd.Parameters.Add("requestDate", today);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Adoption request submitted successfully! Awaiting shelter staff approval.");
                LoadAvailablePetsBySpecies(comboBox1.SelectedItem.ToString());
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request failed: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }



        private int GetNextID(string table, string column)
        {
            OracleCommand cmd = new OracleCommand($"SELECT NVL(MAX({column}), 0) + 1 FROM {table}", conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(currentUser);
            form8.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(currentUser);
            form9.Show();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label6_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(currentUser);  // Pass currentUser to Form14
            form14.Show();  // Opens Form14
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a Pet ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connectdb();

                int petID = int.Parse(textBox1.Text);
                int userID = currentUser.UserID;
                int requestID = GetNextID("FosterRequests", "RequestID");
                DateTime today = DateTime.Today;

                // Check pet availability
                OracleCommand checkCmd = new OracleCommand("SELECT Status FROM Pets WHERE PetID = :petID", conn);
                checkCmd.Parameters.Add("petID", petID);
                string status = Convert.ToString(checkCmd.ExecuteScalar());

                if (status != "Available")
                {
                    MessageBox.Show("This pet is not available for fostering.");
                    return;
                }

                // Increment inquiries
                OracleCommand updateInquiryCmd = new OracleCommand(
                    "UPDATE Pets SET Inquiries = NVL(Inquiries, 0) + 1 WHERE PetID = :petID", conn);
                updateInquiryCmd.Parameters.Add("petID", petID);
                updateInquiryCmd.ExecuteNonQuery();

                OracleCommand updateAnalyticsCmd = new OracleCommand(
                    "UPDATE Analytics SET Inquiries = NVL(Inquiries, 0) + 1 WHERE PetID = :petID", conn);
                updateAnalyticsCmd.Parameters.Add("petID", petID);
                updateAnalyticsCmd.ExecuteNonQuery();

                // Insert foster request with 'Pending' status
                OracleCommand insertCmd = new OracleCommand(
                    "INSERT INTO FosterRequests (RequestID, PetID, UserID, RequestDate, Status) VALUES (:requestID, :petID, :userID, :requestDate, 'Pending')", conn);
                insertCmd.Parameters.Add("requestID", requestID);
                insertCmd.Parameters.Add("petID", petID);
                insertCmd.Parameters.Add("userID", userID);
                insertCmd.Parameters.Add("requestDate", today);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Foster request submitted successfully! Awaiting shelter staff approval.");
                LoadAvailablePetsBySpecies(comboBox1.SelectedItem.ToString());
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foster request failed: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }



    }
}
