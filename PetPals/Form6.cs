using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetPals
{
    public partial class Form6 : Form
    {
        // Dictionary for breed status (Pending, Approved, Rejected)
        private Dictionary<string, string> breedStatus = new Dictionary<string, string>()
        {
            { "Labrador", "Approved" },
            { "German Shepherd", "Pending" },
            { "Golden Retriever", "Approved" },
            { "Poodle", "Rejected" },
            { "Persian Cat", "Approved" },
            { "Siamese Cat", "Pending" },
            { "Maine Coon", "Rejected" }
        };

        // Dictionary for breed behavioral comments
        private Dictionary<string, string> breedBehavior = new Dictionary<string, string>()
        {
            { "Labrador", "Friendly and energetic." },
            { "German Shepherd", "Loyal and protective, needs training." },
            { "Golden Retriever", "Gentle and intelligent, great for families." },
            { "Poodle", "Highly intelligent but needs grooming." },
            { "Persian Cat", "Calm and affectionate but requires maintenance." },
            { "Siamese Cat", "Vocal and active, loves attention." },
            { "Maine Coon", "Large and gentle, great with kids." }
        };

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Populate ComboBox1 with breed names
            comboBox1.Items.AddRange(breedStatus.Keys.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBreed = comboBox1.SelectedItem.ToString();

            // Update Label8 with status
            if (breedStatus.ContainsKey(selectedBreed))
            {
                label8.Text = breedStatus[selectedBreed];
            }
            else
            {
                label8.Text = "Unknown";
            }

            // Update Label9 with behavioral comment
            if (breedBehavior.ContainsKey(selectedBreed))
            {
                label9.Text = breedBehavior[selectedBreed];
            }
            else
            {
                label9.Text = "No data available.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your request has been submitted");
        }
    }
}
