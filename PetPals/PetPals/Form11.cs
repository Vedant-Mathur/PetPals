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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            // Set fixed size
            this.Size = new Size(800, 600);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Open at center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Medical Status Updated Successfully.");
            this.Close();

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
