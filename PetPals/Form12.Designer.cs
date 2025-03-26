namespace PetPals
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 199);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Pet ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(405, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 38);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Paw Wow Block", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 48);
            label1.TabIndex = 3;
            label1.Text = "Delete Pet";
            // 
            // button1
            // 
            button1.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(346, 341);
            button1.Name = "button1";
            button1.Size = new Size(100, 43);
            button1.TabIndex = 4;
            button1.Text = "Delete ID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}