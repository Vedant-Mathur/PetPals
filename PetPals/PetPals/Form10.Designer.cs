namespace PetPals
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            button2 = new Button();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label13 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(346, 380);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(138, 43);
            button2.TabIndex = 54;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Adopeted", "Fostered" });
            comboBox1.Location = new Point(438, 301);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 53;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(438, 222);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(152, 42);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(79, 14);
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
            radioButton1.Location = new Point(5, 14);
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
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(213, 233);
            label13.Name = "label13";
            label13.Size = new Size(82, 25);
            label13.TabIndex = 51;
            label13.Text = "Gender:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(438, 269);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(153, 23);
            textBox7.TabIndex = 49;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(438, 206);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(153, 23);
            textBox6.TabIndex = 48;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(438, 175);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 23);
            textBox5.TabIndex = 47;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(438, 143);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 23);
            textBox4.TabIndex = 46;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(438, 113);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 45;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(438, 79);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 44;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(213, 299);
            label11.Name = "label11";
            label11.Size = new Size(74, 25);
            label11.TabIndex = 42;
            label11.Text = "Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(210, 265);
            label10.Name = "label10";
            label10.Size = new Size(166, 25);
            label10.TabIndex = 41;
            label10.Text = "Medical Details: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(213, 203);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 40;
            label9.Text = "Age: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(213, 173);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 39;
            label8.Text = "Breed:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(210, 140);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 38;
            label7.Text = "Species: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(210, 110);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 37;
            label6.Text = "Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 76);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 36;
            label5.Text = "PetID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Catty Pillow Demo", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(315, 18);
            label3.Name = "label3";
            label3.Size = new Size(179, 33);
            label3.TabIndex = 35;
            label3.Text = "Add new Pet";
            label3.Click += label3_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        // Add this method to handle the SelectedIndexChanged event for comboBox1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add your logic here for when the selected index changes
        }
        // Add this method to handle the TextChanged event for textBox3
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for when the text in textBox3 changes
        }
        // Add this method to handle the Enter event for groupBox1
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Add your logic here for when groupBox1 is entered
        }

        // Add this method to handle the CheckedChanged event for radioButton2
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Add your logic here for when radioButton2 is checked or unchecked
        }

        // Add this method to handle the CheckedChanged event for radioButton1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Add your logic here for when radioButton1 is checked or unchecked
        }

        // Add this method to handle the TextChanged event for textBox7
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for when the text in textBox7 changes
        }

        // Add this method to handle the TextChanged event for textBox6
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for when the text in textBox6 changes
        }

        // Add this method to handle the TextChanged event for textBox5
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for when the text in textBox5 changes
        }

        // Add this method to handle the TextChanged event for textBox4
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for when the text in textBox4 changes
        }

        // Add this method to handle the TextChanged event for textBox2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for when the text in textBox2 changes
        }

        #endregion

        private Button button2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label13;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
    }
}