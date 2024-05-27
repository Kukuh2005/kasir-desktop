namespace kasir
{
    partial class Penjualan
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
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1260, 100);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(114, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(114, 9);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(195, 23);
            textBox6.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 11);
            label9.Name = "label9";
            label9.Size = new Size(48, 16);
            label9.TabIndex = 7;
            label9.Text = "Faktur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuBar;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(506, 37);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 6;
            label4.Text = "Total : ";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.MenuBar;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(491, 9);
            label3.Name = "label3";
            label3.Size = new Size(755, 81);
            label3.TabIndex = 5;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 3;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 2;
            label2.Text = "Cari Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 1;
            label1.Text = "Tanggal";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(485, 101);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Location = new Point(503, 118);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(769, 335);
            dataGridView2.TabIndex = 6;
            dataGridView2.TabStop = false;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode Barang";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Produk";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Jumlah";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Harga";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 228);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(200, 152);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 24;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(114, 152);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 23;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(114, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 23);
            textBox5.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 116);
            label8.Name = "label8";
            label8.Size = new Size(45, 16);
            label8.TabIndex = 21;
            label8.Text = "Harga";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(114, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 23);
            textBox4.TabIndex = 20;
            textBox4.KeyDown += textBox4_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 87);
            label7.Name = "label7";
            label7.Size = new Size(51, 16);
            label7.TabIndex = 19;
            label7.Text = "Jumlah";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(114, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 23);
            textBox3.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 58);
            label6.Name = "label6";
            label6.Size = new Size(51, 16);
            label6.TabIndex = 17;
            label6.Text = "Produk";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(114, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 29);
            label5.Name = "label5";
            label5.Size = new Size(89, 16);
            label5.TabIndex = 15;
            label5.Text = "Kode Barang";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(447, 495);
            button3.Name = "button3";
            button3.Size = new Size(80, 30);
            button3.TabIndex = 8;
            button3.Text = "Bayar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(550, 495);
            button4.Name = "button4";
            button4.Size = new Size(97, 30);
            button4.TabIndex = 9;
            button4.Text = "Transaksi Baru";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(759, 495);
            button5.Name = "button5";
            button5.Size = new Size(80, 30);
            button5.TabIndex = 10;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(663, 495);
            button6.Name = "button6";
            button6.Size = new Size(80, 30);
            button6.TabIndex = 11;
            button6.Text = "Hapus";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Penjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 561);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Penjualan";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Penjualan";
            Load += Penjualan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        public Label label3;
        private Button button6;
        private Label label9;
        public TextBox textBox6;
        public DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        public DateTimePicker dateTimePicker1;
    }
}