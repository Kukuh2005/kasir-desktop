using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kasir
{
    public partial class menuUtama : Form
    {
        public static menuUtama menu;
        MenuStrip mnstrip;
        Login frmLogin;
        DataKasir dataKasir;
        DataBarang dataBarang;
        Penjualan penjualan;
        LaporanPenjualan lp_Penjualan;
        LaporanDataMaster lp_DataMaster;
        GantiPassword gantipassword;
        About about;
        Pembelian pembelian;

        Koneksi Konn = new Koneksi();
        void frmLogin_closed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }

        void dataKasir_closed(object sender, FormClosedEventArgs e)
        {
            dataKasir = null;
        }

        void dataBarang_closed(object sender, FormClosedEventArgs e)
        {
            dataBarang = null;
        }

        void penjualan_closed(object sender, FormClosedEventArgs e)
        {
            penjualan = null;
        }

        void lp_Penjualan_closed(object sender, FormClosedEventArgs e)
        {
            lp_Penjualan = null;
        }

        void lp_DataMaster_closed(object sender, FormClosedEventArgs e)
        {
            lp_DataMaster = null;
        }

        void gantipassword_closed(object sender, FormClosedEventArgs e)
        {
            gantipassword = null;
        }

        void about_closed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }

        void pembelian_closed(object sender, FormClosedEventArgs e)
        {
            pembelian = null;
        }

        void menuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuLaporan.Enabled = false;
            menu = this;
        }

        public menuUtama()
        {
            InitializeComponent();
        }

        private void menuUtama_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuUtama_Load(object sender, EventArgs e)
        {
            menuTerkunci();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new Login();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_closed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            menuTerkunci();
        }

        private void menuKasir_Click(object sender, EventArgs e)
        {
            if (dataKasir == null)
            {
                dataKasir = new DataKasir();
                dataKasir.FormClosed += new FormClosedEventHandler(dataKasir_closed);
                dataKasir.ShowDialog();
            }
            else
            {
                dataKasir.Activate();
            }
        }

        private void menuBarang_Click(object sender, EventArgs e)
        {
            if (dataBarang == null)
            {
                dataBarang = new DataBarang();
                dataBarang.FormClosed += new FormClosedEventHandler(dataBarang_closed);
                dataBarang.ShowDialog();
            }
            else
            {
                dataBarang.Activate();
            }
        }

        private void menuPenjualan_Click(object sender, EventArgs e)
        {
            if (penjualan == null)
            {
                penjualan = new Penjualan();
                penjualan.FormClosed += new FormClosedEventHandler(penjualan_closed);
                penjualan.ShowDialog();
            }
            else
            {
                penjualan.Activate();
            }
        }

        private void menuLaporanPenjualan_Click(object sender, EventArgs e)
        {
            if (lp_Penjualan == null)
            {
                lp_Penjualan = new LaporanPenjualan();
                lp_Penjualan.FormClosed += new FormClosedEventHandler(lp_Penjualan_closed);
                lp_Penjualan.ShowDialog();
            }
            else
            {
                lp_Penjualan.Activate();
            }
        }

        private void menuLaporanDataMaster_Click(object sender, EventArgs e)
        {
            if (lp_DataMaster == null)
            {
                lp_DataMaster = new LaporanDataMaster();
                lp_DataMaster.FormClosed += new FormClosedEventHandler(lp_DataMaster_closed);
                lp_DataMaster.ShowDialog();
            }
            else
            {
                lp_DataMaster.Activate();
            }
        }

        private void menuGantiPassword_Click(object sender, EventArgs e)
        {
            if (gantipassword == null)
            {
                gantipassword = new GantiPassword();
                gantipassword.FormClosed += new FormClosedEventHandler(gantipassword_closed);
                gantipassword.ShowDialog();
            }
            else
            {
                gantipassword.Activate();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new About();
                about.FormClosed += new FormClosedEventHandler(about_closed);
                about.ShowDialog();
            }
            else
            {
                about.Activate();
            }
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pembelian == null)
            {
                pembelian = new Pembelian();
                pembelian.FormClosed += new FormClosedEventHandler(pembelian_closed);
                pembelian.ShowDialog();
            }
            else
            {
                pembelian.Activate();
            }

        }
    }
}
