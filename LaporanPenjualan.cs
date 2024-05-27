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
    public partial class LaporanPenjualan : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        public LaporanPenjualan()
        {
            InitializeComponent();
        }

        Koneksi Konn = new Koneksi();

        void TampilTransaksi()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_Transaksi", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Transaksi");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Transaksi";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void LaporanPenjualan_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            TampilTransaksi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_Transaksi where Tanggal BETWEEN '"+ dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm") + "' AND '"+ dateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm") + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Transaksi");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_Transaksi";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
