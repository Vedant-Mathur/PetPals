using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PetPals
{
    public partial class Form7 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public void connectdb()
        {
            String oradb = "USER ID=system;PASSWORD=dbms123;DATA SOURCE=X_360:1521/XE;TNS_ADMIN=C:\\Users\\b5171\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        public Form7()
        {
            InitializeComponent();
        }



        private UserInfo currentUser;

        public Form7(UserInfo userInfo)
        {
            InitializeComponent();
            currentUser = userInfo;
            // Set fixed size
            this.Size = new Size(800, 600);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Open at center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(currentUser);
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();


        }
    }
}
