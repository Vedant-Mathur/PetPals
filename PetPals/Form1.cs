using System;
using System.Text.RegularExpressions; 
using System.Windows.Forms;

namespace PetPals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox1.Text))
            {
                textBox1.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
            }



        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();  // Put cursor back in the textbox
                textBox1.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                MessageBox.Show("Email is valid! Proceeding...",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.BackColor = System.Drawing.Color.White;
                // You can add code here to proceed with form submission
            }
            if (textBox1.Text.Trim().EndsWith("@admin.com", StringComparison.OrdinalIgnoreCase))
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else if (textBox1.Text.Trim().EndsWith("@foster.com", StringComparison.OrdinalIgnoreCase))
            {
                Form6 f6 = new Form6();
                f6.Show();
            }
            else if (textBox1.Text.Trim().EndsWith("@staff.com", StringComparison.OrdinalIgnoreCase))
            {
                Form7 f7 = new Form7();
                f7.Show();
            }
            else if (textBox1.Text.Trim().EndsWith("@adopter.com", StringComparison.OrdinalIgnoreCase))
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
