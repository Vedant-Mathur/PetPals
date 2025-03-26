namespace PetPals
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            label6 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Paw Wow Block", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome PetPal!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Available Pets:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(276, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(724, 9);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 3;
            label3.Text = "Profile";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(391, 411);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Rate Us?";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Catty Pillow Demo", 18F);
            label5.Location = new Point(102, 167);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 5;
            label5.Text = "Breed:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Catty Pillow Demo", 18F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(276, 167);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(348, 33);
            comboBox2.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Catty Pillow Demo", 18F);
            radioButton1.Location = new Point(20, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Catty Pillow Demo", 18F);
            radioButton2.Location = new Point(115, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(276, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 73);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Catty Pillow Demo", 18F);
            label6.Location = new Point(95, 249);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 10;
            label6.Text = "Gender:";
            // 
            // button1
            // 
            button1.Font = new Font("Catty Pillow Demo", 18F);
            button1.Location = new Point(276, 342);
            button1.Name = "button1";
            button1.Size = new Size(277, 38);
            button1.TabIndex = 12;
            button1.Text = "Check Availability";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label label6;
        private Button button1;
    }
}