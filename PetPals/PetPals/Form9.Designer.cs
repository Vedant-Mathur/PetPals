namespace PetPals
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label2 = new Label();
            textBoxPetID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Paw Wow Block", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 48);
            label1.TabIndex = 0;
            label1.Text = "Feedback Form";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 144);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 2;
            label3.Text = "Rate Our Services?";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(350, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 29);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(144, 263);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 4;
            label4.Text = "Comments:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(350, 261);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(199, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Catty Pillow Demo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(286, 471);
            button1.Name = "button1";
            button1.Size = new Size(128, 41);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 209);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 7;
            label2.Text = "Pet ID";
            // 
            // textBoxPetID
            // 
            textBoxPetID.Location = new Point(350, 209);
            textBoxPetID.Name = "textBoxPetID";
            textBoxPetID.Size = new Size(100, 29);
            textBoxPetID.TabIndex = 8;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(709, 630);
            Controls.Add(textBoxPetID);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form9";
            Text = "Feedback Form";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        // Add this method to handle the label1_Click event
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your event handling logic here
            MessageBox.Show("Label1 clicked!");
        }
        // Add this method to handle the comboBox1_SelectedIndexChanged event
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add your event handling logic here
            MessageBox.Show($"You selected: {comboBox1.SelectedItem}");
        }
        // Add this method to handle the richTextBox1_TextChanged event
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Add your event handling logic here
            MessageBox.Show("Text changed in the comments box!");
        }
        // Add this method to handle the Form9_Load event
        private void Form9_Load(object sender, EventArgs e)
        {
            // Add your initialization logic here
            MessageBox.Show("Form9 has loaded!");
        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label2;
        private TextBox textBoxPetID;
    }
}