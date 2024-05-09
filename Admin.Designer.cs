namespace SR
{
    partial class Admin
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(104, 371);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 36);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 374);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 2;
            label1.Text = "Кур'єр";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(802, 279);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(373, 332);
            button1.Name = "button1";
            button1.Size = new Size(171, 64);
            button1.TabIndex = 4;
            button1.Text = "Призначити замовлення";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(633, 356);
            button2.Name = "button2";
            button2.Size = new Size(181, 64);
            button2.TabIndex = 5;
            button2.Text = "На вікно реєстрації";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 332);
            label2.Name = "label2";
            label2.Size = new Size(40, 28);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(104, 330);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 35);
            numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 0);
            label3.Name = "label3";
            label3.Size = new Size(306, 28);
            label3.TabIndex = 8;
            label3.Text = "Не прийняті замовлення";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 421);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
    }
}