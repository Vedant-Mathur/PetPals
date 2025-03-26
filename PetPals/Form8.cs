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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string email = textBox.Text;
                if (!email.Contains("@") || !email.Contains("."))
                {
                    textBox.BackColor = Color.Red;
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string password = textBox.Text;
                if (password.Length != 10)
                {
                    textBox.BackColor = Color.Red;
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile Has Been Updated");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
