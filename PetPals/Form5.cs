using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetPals
{
    public partial class Form5 : Form
    {
        // Dictionary to store animals and their respective breeds
        private Dictionary<string, List<string>> animalBreeds = new Dictionary<string, List<string>>()
        {
            { "Dog", new List<string> { "Labrador", "German Shepherd", "Golden Retriever", "Poodle" } },
            { "Cat", new List<string> { "Persian", "Siamese", "Maine Coon", "Bengal" } },
            { "Bird", new List<string> { "Parrot", "Canary", "Sparrow", "Macaw" } },
            { "Fish", new List<string> { "Goldfish", "Betta", "Guppy", "Angelfish" } }
        };

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Populate comboBox1 with animal types
            comboBox1.Items.AddRange(animalBreeds.Keys.ToArray());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected animal
            string selectedAnimal = comboBox1.SelectedItem.ToString();

            // Clear and update comboBox2 based on selection
            comboBox2.Items.Clear();
            if (animalBreeds.ContainsKey(selectedAnimal))
            {
                comboBox2.Items.AddRange(animalBreeds[selectedAnimal].ToArray());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if ComboBox1 has a selection
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if ComboBox2 has a selection
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a breed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if all TextBoxes are filled
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // If all fields are filled, show success message
            MessageBox.Show("Thank you for your submission. We will contact you shortly.", "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
