using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace PetPals
{
    public partial class Form10 : Form
    {
        public Form10()
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

        private void Form10_Load(object sender, EventArgs e)
        {
            // Populate status options in comboBox1
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Available");
            comboBox1.Items.Add("Adopted");
            comboBox1.Items.Add("Fostered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
                using (OracleConnection conn = new OracleConnection(oradb))
                {
                    conn.Open();

                    // Determine Gender
                    string gender = "";
                    if (radioButton1.Checked)
                        gender = "Male";
                    else if (radioButton2.Checked)
                        gender = "Female";
                    else
                    {
                        MessageBox.Show("Please select the pet's gender.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(comboBox1.Text))
                    {
                        MessageBox.Show("Please select the pet's status.");
                        return;
                    }

                    // Insert Pet Data
                    string insertPetQuery = "INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status) " +
                                            "VALUES (:petId, :name, :species, :breed, :age, :gender, :medicalDetails, :status)";

                    using (OracleCommand cmd = new OracleCommand(insertPetQuery, conn))
                    {
                        cmd.Parameters.Add(":petId", OracleDbType.Int32).Value = Convert.ToInt32(textBox2.Text);
                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = textBox3.Text;
                        cmd.Parameters.Add(":species", OracleDbType.Varchar2).Value = textBox4.Text;
                        cmd.Parameters.Add(":breed", OracleDbType.Varchar2).Value = textBox5.Text;
                        cmd.Parameters.Add(":age", OracleDbType.Int32).Value = Convert.ToInt32(textBox6.Text);
                        cmd.Parameters.Add(":gender", OracleDbType.Varchar2).Value = gender;
                        cmd.Parameters.Add(":medicalDetails", OracleDbType.Varchar2).Value = textBox7.Text;
                        cmd.Parameters.Add(":status", OracleDbType.Varchar2).Value = comboBox1.Text;

                        cmd.ExecuteNonQuery();
                    }

                    // Get next MedicalHistorySeq value
                    int historyId = 0;
                    string getSeqQuery = "SELECT MedicalHistorySeq.NEXTVAL FROM DUAL";
                    using (OracleCommand seqCmd = new OracleCommand(getSeqQuery, conn))
                    {
                        historyId = Convert.ToInt32(seqCmd.ExecuteScalar());
                    }

                    // Insert into MedicalHistory with retrieved HistoryID
                    string insertHistoryQuery = "INSERT INTO MedicalHistory (HistoryID, PetID, VaccinationRecords, Allergies, ChronicIllness, LastCheckupDate) " +
                                                "VALUES (:historyId, :petId, '', '', '', SYSDATE)";

                    using (OracleCommand cmdHist = new OracleCommand(insertHistoryQuery, conn))
                    {
                        cmdHist.Parameters.Add(":historyId", OracleDbType.Int32).Value = historyId;
                        cmdHist.Parameters.Add(":petId", OracleDbType.Int32).Value = Convert.ToInt32(textBox2.Text);
                        cmdHist.ExecuteNonQuery();
                    }

                    // Show success message along with generated MedicalHistoryID
                    textBox7.Text = $"Pet added. Medical History ID: {historyId}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding pet: " + ex.Message);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
