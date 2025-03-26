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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();

            form10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }
    }
}
