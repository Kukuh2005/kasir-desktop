namespace kasir
{
    partial class Pembayaran
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 81);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 0;
            label1.Text = "Total : ";
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(196, 57);
            label2.Name = "label2";
            label2.Size = new Size(450, 69);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 207);
            label4.Name = "label4";
            label4.Size = new Size(113, 18);
            label4.TabIndex = 2;
            label4.Text = "Total Bayar :";
            // 
            // label5
            // 
            label5.BackColor = Color.FloralWhite;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(196, 369);
            label5.Name = "label5";
            label5.Size = new Size(450, 69);
            label5.TabIndex = 5;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 393);
            label6.Name = "label6";
            label6.Size = new Size(86, 18);
            label6.TabIndex = 4;
            label6.Text = "Kembali :";
            // 
            // button1
            // 
            button1.Location = new Point(196, 491);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 6;
            button1.Text = "Bayar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 491);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Lime;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(196, 249);
            label3.Name = "label3";
            label3.Size = new Size(450, 69);
            label3.TabIndex = 3;
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 8;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ButtonFace;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(327, 207);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 9;
            label7.Text = "20.000";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ButtonFace;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(433, 207);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 10;
            label8.Text = "50.000";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonFace;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(539, 207);
            label9.Name = "label9";
            label9.Size = new Size(107, 23);
            label9.TabIndex = 11;
            label9.Text = "100.000";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 569);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pembayaran";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pembayaran";
            Load += Pembayaran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}