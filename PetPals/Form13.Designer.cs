namespace PetPals
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Paw Wow Block", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 25);
            label1.Name = "label1";
            label1.Size = new Size(375, 48);
            label1.TabIndex = 0;
            label1.Text = "Update Pet Availability";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Catty Pillow Demo", 18F);
            label2.Location = new Point(248, 137);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Pet ID:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(408, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 148);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Catty Pillow Demo", 18F);
            radioButton1.Location = new Point(11, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Available";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Catty Pillow Demo", 18F);
            radioButton2.Location = new Point(11, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Adopted";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Catty Pillow Demo", 18F);
            radioButton3.Location = new Point(11, 113);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(108, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Fostered";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(408, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 39);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(347, 368);
            button1.Name = "button1";
            button1.Size = new Size(176, 43);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form13";
            Text = "Form13";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Button button1;
    }
}