namespace kasir
{
    partial class menuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuUtama));
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            menuMaster = new ToolStripMenuItem();
            menuKasir = new ToolStripMenuItem();
            menuBarang = new ToolStripMenuItem();
            menuTransaksi = new ToolStripMenuItem();
            menuPenjualan = new ToolStripMenuItem();
            pembelianToolStripMenuItem = new ToolStripMenuItem();
            menuLaporan = new ToolStripMenuItem();
            menuLaporanDataMaster = new ToolStripMenuItem();
            menuLaporanPenjualan = new ToolStripMenuItem();
            menuUtility = new ToolStripMenuItem();
            menuGantiPassword = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.PowderBlue;
            menuStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuMaster, menuTransaksi, menuLaporan, menuUtility });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuLogout, toolStripMenuItem1, menuExit });
            menuFile.ForeColor = SystemColors.ActiveCaptionText;
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(41, 36);
            menuFile.Text = "File";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(119, 22);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(119, 22);
            menuLogout.Text = "Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(119, 22);
            menuExit.Text = "Exit";
            menuExit.Click += exitToolStripMenuItem_Click;
            // 
            // menuMaster
            // 
            menuMaster.DropDownItems.AddRange(new ToolStripItem[] { menuKasir, menuBarang });
            menuMaster.Name = "menuMaster";
            menuMaster.Size = new Size(64, 36);
            menuMaster.Text = "Master";
            // 
            // menuKasir
            // 
            menuKasir.Name = "menuKasir";
            menuKasir.Size = new Size(119, 22);
            menuKasir.Text = "Kasir";
            menuKasir.Click += menuKasir_Click;
            // 
            // menuBarang
            // 
            menuBarang.Name = "menuBarang";
            menuBarang.Size = new Size(119, 22);
            menuBarang.Text = "Barang";
            menuBarang.Click += menuBarang_Click;
            // 
            // menuTransaksi
            // 
            menuTransaksi.DropDownItems.AddRange(new ToolStripItem[] { menuPenjualan, pembelianToolStripMenuItem });
            menuTransaksi.Name = "menuTransaksi";
            menuTransaksi.Size = new Size(80, 36);
            menuTransaksi.Text = "Transaksi";
            // 
            // menuPenjualan
            // 
            menuPenjualan.Name = "menuPenjualan";
            menuPenjualan.Size = new Size(139, 22);
            menuPenjualan.Text = "Penjualan";
            menuPenjualan.Click += menuPenjualan_Click;
            // 
            // pembelianToolStripMenuItem
            // 
            pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            pembelianToolStripMenuItem.Size = new Size(139, 22);
            pembelianToolStripMenuItem.Text = "Pembelian";
            pembelianToolStripMenuItem.Click += pembelianToolStripMenuItem_Click;
            // 
            // menuLaporan
            // 
            menuLaporan.DropDownItems.AddRange(new ToolStripItem[] { menuLaporanDataMaster, menuLaporanPenjualan });
            menuLaporan.Name = "menuLaporan";
            menuLaporan.Size = new Size(71, 36);
            menuLaporan.Text = "Laporan";
            // 
            // menuLaporanDataMaster
            // 
            menuLaporanDataMaster.Name = "menuLaporanDataMaster";
            menuLaporanDataMaster.Size = new Size(188, 22);
            menuLaporanDataMaster.Text = "Lap. Data Master";
            menuLaporanDataMaster.Click += menuLaporanDataMaster_Click;
            // 
            // menuLaporanPenjualan
            // 
            menuLaporanPenjualan.Name = "menuLaporanPenjualan";
            menuLaporanPenjualan.Size = new Size(188, 22);
            menuLaporanPenjualan.Text = "Lap. Penjualan";
            menuLaporanPenjualan.Click += menuLaporanPenjualan_Click;
            // 
            // menuUtility
            // 
            menuUtility.DropDownItems.AddRange(new ToolStripItem[] { menuGantiPassword, menuAbout });
            menuUtility.Name = "menuUtility";
            menuUtility.Size = new Size(57, 36);
            menuUtility.Text = "Utility";
            // 
            // menuGantiPassword
            // 
            menuGantiPassword.Name = "menuGantiPassword";
            menuGantiPassword.Size = new Size(175, 22);
            menuGantiPassword.Text = "Ganti Password";
            menuGantiPassword.Click += menuGantiPassword_Click;
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(175, 22);
            menuAbout.Text = "About";
            menuAbout.Click += menuAbout_Click;
            // 
            // menuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "menuUtama";
            Text = "Kasir";
            WindowState = FormWindowState.Maximized;
            FormClosing += menuUtama_FormClosing;
            Load += menuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuKasir;
        private ToolStripMenuItem menuBarang;
        private ToolStripMenuItem menuPenjualan;
        private ToolStripMenuItem menuLaporanDataMaster;
        private ToolStripMenuItem menuLaporanPenjualan;
        private ToolStripMenuItem menuGantiPassword;
        private ToolStripMenuItem menuAbout;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem transaksiToolStripMenuItem;
        private ToolStripMenuItem laporanToolStripMenuItem;
        private ToolStripMenuItem utilToolStripMenuItem;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem menuFile;
        public ToolStripMenuItem menuLogin;
        public ToolStripMenuItem menuLogout;
        public ToolStripMenuItem menuMaster;
        public ToolStripMenuItem menuTransaksi;
        public ToolStripMenuItem menuLaporan;
        public ToolStripMenuItem menuUtility;
        private ToolStripMenuItem pembelianToolStripMenuItem;
    }
}