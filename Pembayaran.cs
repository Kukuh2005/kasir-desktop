using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace kasir
{
    public partial class Pembayaran : Form
    {

        Penjualan penjualan;
        decimal total, totalbayar, kembali;
        public Pembayaran(Penjualan penjualan)
        {
            InitializeComponent();
            this.penjualan = penjualan;
        }

        Koneksi Konn = new Koneksi();
        private SqlCommand cmd;

        void Hitung()
        {
            total = Convert.ToDecimal(label2.Text);
            totalbayar = Convert.ToDecimal(label3.Text);

            kembali = totalbayar - total;

            if (total > totalbayar)
            {
                MessageBox.Show("Total Bayar kurang dari Harga Total");
                label5.Text = "0";
                button1.Enabled = false;
            }
            else if (total == totalbayar)
            {
                label5.Text = "0";
                button1.Enabled = true;
            }
            else
            {
                label5.Text = Convert.ToString(kembali);
                button1.Enabled = true;
            }
        }
        void laporanBarang()
        {
            for (int i = 0; i < penjualan.dataGridView2.Rows.Count; i++)
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("INSERT INTO LP_DataMasterBarang values('" + penjualan.textBox6.Text + "', '" + penjualan.dateTimePicker1.Value.ToString() + "', 'Jual', '" + penjualan.dataGridView2.Rows[i].Cells[0].Value.ToString() + "', '" + penjualan.dataGridView2.Rows[i].Cells[1].Value.ToString() + "', '" + penjualan.dataGridView2.Rows[i].Cells[2].Value.ToString() + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        void UpdateJumlah()
        {
            for (int i = 0; i < penjualan.dataGridView2.Rows.Count; i++)
            {
                string jumlah = penjualan.dataGridView2.Rows[i].Cells[2].Value.ToString();
                string Kode = penjualan.dataGridView2.Rows[i].Cells[0].Value.ToString();
                decimal dbJumlah, hasil;
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("SELECT JumlahBarang FROM TBL_Barang where KodeBarang='" + penjualan.dataGridView2.Rows[i].Cells[0].Value.ToString() + "'", conn);
                conn.Open();
                dbJumlah = (decimal)cmd.ExecuteScalar();
                conn.Close();

                decimal jumlahBarang = Convert.ToDecimal(jumlah);
                hasil = dbJumlah - jumlahBarang;

                if (dbJumlah != 0)
                {
                    cmd = new SqlCommand("UPDATE TBL_Barang set JumlahBarang='" + hasil + "' where KodeBarang='" + Kode + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Kode Barang = " + Kode + " (Stock Habis)");
                }
            }
        }

        void LaporanTransaksi()
        {
            SqlConnection conn = Konn.GetConn();

            cmd = new SqlCommand("INSERT INTO TBL_Transaksi values('" + penjualan.textBox6.Text + "', '" + penjualan.dateTimePicker1.Value.ToString() + "', '" + label2.Text + "', '" + label3.Text + "', '" + label5.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            label2.Text = penjualan.label3.Text;
            textBox1.Focus();
            button1.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label3.Text = textBox1.Text;
                textBox1.Text = "";
                Hitung();
                button1.Focus();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label3.Text = "20000";
            Hitung();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label3.Text = "50000";
            Hitung();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label3.Text = "100000";
            Hitung();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lakukan Pembayaran ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    laporanBarang();
                    LaporanTransaksi();
                    UpdateJumlah();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
}
