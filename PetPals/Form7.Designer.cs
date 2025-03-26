namespace PetPals
{
    partial class Form7
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Paw Wow Block", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(267, 19);
            label2.Name = "label2";
            label2.Size = new Size(265, 48);
            label2.TabIndex = 1;
            label2.Text = "Hello, CareTaker!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(719, 19);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 3;
            label3.Text = "Profile";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Catty Pillow Demo", 18F);
            button1.Location = new Point(255, 113);
            button1.Name = "button1";
            button1.Size = new Size(288, 39);
            button1.TabIndex = 4;
            button1.Text = "Add Pet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Catty Pillow Demo", 18F);
            button2.Location = new Point(255, 370);
            button2.Name = "button2";
            button2.Size = new Size(288, 41);
            button2.TabIndex = 5;
            button2.Text = "Delete Pet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Catty Pillow Demo", 18F);
            button3.Location = new Point(255, 283);
            button3.Name = "button3";
            button3.Size = new Size(288, 39);
            button3.TabIndex = 6;
            button3.Text = "Add Medical History";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Catty Pillow Demo", 18F);
            button5.Location = new Point(256, 195);
            button5.Name = "button5";
            button5.Size = new Size(288, 41);
            button5.TabIndex = 8;
            button5.Text = " Manage Requests";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cute_pattern_with_dog_faces_bones_1191_1204;
            ClientSize = new Size(784, 461);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}