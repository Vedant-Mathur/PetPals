using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PetPals
{
    public partial class Form14 : Form
    {
        private OracleConnection conn;
        private UserInfo currentUser; // Store the user

        // Constructor
        public Form14()
        {
            // Set fixed size
            this.Size = new Size(800, 600);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Open at center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public Form14(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;

            // Attach event handler for CellContentClick
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // Set fixed size
            this.Size = new Size(800, 600);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Open at center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        // Database connection method
        private void ConnectToDatabase()
        {
            string connectionString = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            conn = new OracleConnection(connectionString);
            conn.Open();
        }

        // Load adopted and fostered pets based on user ID
        private void LoadPetData(int userID)
        {
            // Fetch adopted pets by joining Pets and AdoptionRecords tables
            string adoptedQuery = @"
                SELECT p.*
                FROM Pets p
                JOIN AdoptionRecords ar ON p.PetID = ar.PetID
                WHERE ar.UserID = :userID";
            OracleDataAdapter adoptedAdapter = new OracleDataAdapter(adoptedQuery, conn);
            adoptedAdapter.SelectCommand.Parameters.Add("userID", OracleDbType.Int32).Value = userID;

            DataTable adoptedTable = new DataTable();
            adoptedAdapter.Fill(adoptedTable);

            // Bind the adopted pets data to dataGridView1
            dataGridView1.DataSource = adoptedTable;

            // Fetch fostered pets by joining Pets and FosterCare tables
            string fosteredQuery = @"
                SELECT p.*
                FROM Pets p
                JOIN FosterCare fc ON p.PetID = fc.PetID
                WHERE fc.UserID = :userID";
            OracleDataAdapter fosteredAdapter = new OracleDataAdapter(fosteredQuery, conn);
            fosteredAdapter.SelectCommand.Parameters.Add("userID", OracleDbType.Int32).Value = userID;

            DataTable fosteredTable = new DataTable();
            fosteredAdapter.Fill(fosteredTable);

            // Bind the fostered pets data to dataGridView2
            dataGridView2.DataSource = fosteredTable;
        }

        // Form Load event to initialize and load the data
        private void Form14_Load(object sender, EventArgs e)
        {
            int userID = currentUser.UserID; // Get user ID from passed UserInfo

            ConnectToDatabase();
            LoadPetData(userID);
        }

        // Handle button click if needed (e.g., to close the form)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for CellContentClick in dataGridView1 (Adopted pets)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string petName = row.Cells["Name"].Value.ToString();
                MessageBox.Show("You clicked on adopted pet: " + petName);
            }
        }

        // Event handler for CellContentClick in dataGridView2 (Fostered pets)
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string petName = row.Cells["Name"].Value.ToString();
                MessageBox.Show("You clicked on fostered pet: " + petName);
            }
        }
    }
}
