namespace PetPals
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Paw Wow Block", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 48);
            label1.TabIndex = 0;
            label1.Text = "Hello, Parent!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 122);
            label2.Name = "label2";
            label2.Size = new Size(236, 25);
            label2.TabIndex = 1;
            label2.Text = "Cuurently Fostered Pets:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(728, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Profile";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 201);
            label4.Name = "label4";
            label4.Size = new Size(212, 25);
            label4.TabIndex = 3;
            label4.Text = "Foster Request Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 277);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 4;
            label5.Text = "Behavior Notes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(427, 390);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 5;
            label6.Text = "Return Request";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(259, 385);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(656, 9);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 7;
            label7.Text = "User ID: xyz";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Siberian Husky", "Poodle ", "Persian" });
            comboBox1.Location = new Point(340, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Catty Pillow Demo", 18F);
            label8.Location = new Point(340, 201);
            label8.Name = "label8";
            label8.Size = new Size(73, 25);
            label8.TabIndex = 9;
            label8.Text = "label 8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Catty Pillow Demo", 18F);
            label9.Location = new Point(340, 277);
            label9.Name = "label9";
            label9.Size = new Size(68, 25);
            label9.TabIndex = 10;
            label9.Text = "label9";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
    }
}