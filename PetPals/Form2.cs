using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetPals
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adopter");
            comboBox1.Items.Add("FosterParent");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("ShelterStaff");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox2.Text))
            {
                textBox2.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();  // Put cursor back in the textbox
                textBox2.BackColor = System.Drawing.Color.LightCoral;
                return;
            }

            // Check if all required textboxes are filled
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields before registering.",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
