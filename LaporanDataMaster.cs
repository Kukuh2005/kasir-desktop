using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir
{
    public partial class LaporanDataMaster : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public LaporanDataMaster()
        {
            InitializeComponent();
        }

        void TampilLaporan()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM LP_DataMasterBarang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "LP_DataMasterBarang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "LP_DataMasterBarang";
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

        private void LaporanDataMaster_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            TampilLaporan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM LP_DataMasterBarang where Tanggal BETWEEN '" + dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm") + "' AND '" + dateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm") + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "LP_DataMasterBarang");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "LP_DataMasterBarang";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
