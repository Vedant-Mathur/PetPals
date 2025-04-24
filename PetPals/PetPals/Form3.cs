using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;  // for Oracle DB

namespace PetPals
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Available");
            comboBox1.Items.Add("Adopted");
            comboBox1.Items.Add("Fostered");

          
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox13_TextChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void tabPage4_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please fill in all text fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool radioSelected = groupBox1.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!radioSelected)
            {
                MessageBox.Show("Please select a gender.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status from the dropdown.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("All fields are filled correctly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox10.Text) ||
                string.IsNullOrWhiteSpace(textBox11.Text) ||
                string.IsNullOrWhiteSpace(textBox12.Text) ||
                string.IsNullOrWhiteSpace(textBox13.Text))
            {
                MessageBox.Show("Please fill in all text fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please select a valid date.", "Missing Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("All fields are filled correctly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function to load Analytics data into DataGridView (Oracle version)
        private void LoadAnalyticsForPet(int petId)
        {
            string connectionString = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            string query = @"SELECT P.PetID, P.Name, P.Species, A.Inquiries
                     FROM Pets P
                     JOIN Analytics A ON P.PetID = A.PetID
                     WHERE P.PetID = :petId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add("petId", OracleDbType.Int32).Value = petId;

                    OracleDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading analytics data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadAdoptedPetsByUser(int userId)
        {
            string connectionString = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand("PetPkg.GetAdoptedPetsByUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Use parameter passed to method, not the TextBox again
                    command.Parameters.Add("p_UserID", OracleDbType.Int32).Value = userId;

                    OracleParameter outCursor = new OracleParameter("out_cursor", OracleDbType.RefCursor);
                    outCursor.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outCursor);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.DataSource = dt;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox14.Text, out int userId))
            {
                LoadAdoptedPetsByUser(userId);
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox15.Text, out int petId))
            {
                LoadAnalyticsForPet(petId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Pet ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
