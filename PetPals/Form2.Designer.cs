namespace PetPals
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Catty Pillow Demo", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 33);
            label1.Name = "label1";
            label1.Size = new Size(301, 33);
            label1.TabIndex = 0;
            label1.Text = "New User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 98);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "User ID: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 148);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Email ID:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 196);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 246);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 4;
            label5.Text = "Full Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(78, 289);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 5;
            label6.Text = "Role:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 342);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 6;
            label7.Text = "Address: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 98);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 148);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 196);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(312, 246);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(312, 342);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 23);
            textBox6.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 292);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(332, 385);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 48);
            button1.TabIndex = 14;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Registration Portal";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private Button button1;
    }
}