namespace PetPals
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label20 = new Label();
            textBox13 = new TextBox();
            label19 = new Label();
            textBox12 = new TextBox();
            label18 = new Label();
            textBox11 = new TextBox();
            label17 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label13 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Catty Pillow Demo", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 7);
            label1.Name = "label1";
            label1.Size = new Size(169, 33);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(954, 512);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(946, 484);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Users";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(313, 188);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 4;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 101);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 101);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 2;
            label4.Text = "Enter UserID:";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 58);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 0;
            label2.Text = "Delete User";
            label2.Click += label2_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(textBox13);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(946, 484);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Pets";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(645, 296);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 35;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(175, 391);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 34;
            button2.Text = "Add Pet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(683, 229);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(467, 229);
            label20.Name = "label20";
            label20.Size = new Size(193, 25);
            label20.TabIndex = 32;
            label20.Text = "Last Checkup Date:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(713, 200);
            textBox13.Margin = new Padding(3, 2, 3, 2);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(153, 23);
            textBox13.TabIndex = 31;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(467, 197);
            label19.Name = "label19";
            label19.Size = new Size(159, 25);
            label19.TabIndex = 30;
            label19.Text = "Chronic Illness: ";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(713, 170);
            textBox12.Margin = new Padding(3, 2, 3, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(153, 23);
            textBox12.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(467, 166);
            label18.Name = "label18";
            label18.Size = new Size(102, 25);
            label18.TabIndex = 28;
            label18.Text = "Allergies: ";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(713, 137);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(153, 23);
            textBox11.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(467, 134);
            label17.Name = "label17";
            label17.Size = new Size(202, 25);
            label17.TabIndex = 26;
            label17.Text = "Vaccination Records: ";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(713, 107);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(153, 23);
            textBox10.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(467, 104);
            label16.Name = "label16";
            label16.Size = new Size(77, 25);
            label16.TabIndex = 24;
            label16.Text = "PetID: ";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(713, 76);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(153, 23);
            textBox9.TabIndex = 23;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(467, 73);
            label15.Name = "label15";
            label15.Size = new Size(120, 25);
            label15.TabIndex = 22;
            label15.Text = "History ID: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Catty Pillow Demo", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(517, 32);
            label14.Name = "label14";
            label14.Size = new Size(287, 33);
            label14.TabIndex = 21;
            label14.Text = "Add Medical History";
            label14.Click += label14_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(255, 298);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(255, 219);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(152, 42);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(79, 15);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(5, 15);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(30, 230);
            label13.Name = "label13";
            label13.Size = new Size(82, 25);
            label13.TabIndex = 16;
            label13.Text = "Gender:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(255, 328);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(153, 23);
            textBox8.TabIndex = 15;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(255, 266);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(153, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(255, 203);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(153, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(255, 172);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(255, 140);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(255, 110);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 76);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(27, 328);
            label12.Name = "label12";
            label12.Size = new Size(193, 25);
            label12.TabIndex = 8;
            label12.Text = "Medical History ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(30, 296);
            label11.Name = "label11";
            label11.Size = new Size(74, 25);
            label11.TabIndex = 7;
            label11.Text = "Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(27, 262);
            label10.Name = "label10";
            label10.Size = new Size(166, 25);
            label10.TabIndex = 6;
            label10.Text = "Medical Details: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 200);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 5;
            label9.Text = "Age: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 170);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 4;
            label8.Text = "Breed:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 137);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 3;
            label7.Text = "Species: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 107);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 2;
            label6.Text = "Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 76);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 1;
            label5.Text = "PetID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Catty Pillow Demo", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 32);
            label3.Name = "label3";
            label3.Size = new Size(179, 33);
            label3.TabIndex = 0;
            label3.Text = "Add new Pet";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(946, 484);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "View Adoptions";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(946, 484);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reports";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(954, 512);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Admin Panel";
            Load += Form3_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label2;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label13;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label14;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Label label20;
        private TextBox textBox13;
        private Label label19;
        private TextBox textBox12;
        private Label label18;
        private TextBox textBox11;
        private Label label17;
        private TextBox textBox10;
        private Label label16;
        private TextBox textBox9;
        private Label label15;
        private Button button3;
        private Button button2;
    }
}