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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Available");
            comboBox1.Items.Add("Adopted");
            comboBox1.Items.Add("Fostered");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

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

            // Check if at least one radio button is selected
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

            // If all validations pass
            MessageBox.Show("All fields are filled correctly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

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

            // If all validations pass
            MessageBox.Show("All fields are filled correctly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
