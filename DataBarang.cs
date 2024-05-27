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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kasir
{
    public partial class DataBarang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            comboBox1.Text = "";
            textBox6.Text = "";
            NoOtomatis();
        }

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBarang from TBL_Barang where KodeBarang in(select max(KodeBarang) from TBL_Barang) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "BRG" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "BRG001";
            }
            rd.Close();
            textBox1.Text = urutan;
            conn.Close();
        }

        void TampilBarang()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_Barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Barang";
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

        void CariBarang()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_Barang where KodeBarang like'%" + textBox6.Text + "%' or NamaBarang like '%" + textBox6.Text + "%' ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Barang";
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

        void satuanCombo()
        {
            comboBox1.Items.Add("PCS");
            comboBox1.Items.Add("KG");
            comboBox1.Items.Add("BOTOL");
            comboBox1.Items.Add("BOX");
        }
        public DataBarang()
        {
            InitializeComponent();
        }

        private void DataBarang_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            TampilBarang();
            Bersihkan();
            NoOtomatis();
            satuanCombo();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim() == "0")
            {
                MessageBox.Show("Jumlah Tidak Boleh 0 !");
                textBox5.Focus();
            }
            else if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update TBL_Barang set NamaBarang = '" + textBox2.Text + "',HargaBeli = '" + textBox3.Text + "',HargaJual = '" + textBox4.Text + "',JumlahBarang = '" + textBox5.Text + "',SatuanBarang = '" + comboBox1.Text + "' where KodeBarang ='" + textBox1.Text + "' ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edit Data Berhasil !");
                    TampilBarang();
                    Bersihkan();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data barang : " + textBox2.Text + " ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("delete TBL_Barang  where KodeBarang ='" + textBox1.Text + "' ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus Data Berhasil !");
                    TampilBarang();
                    Bersihkan();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bersihkan();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox2.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox3.Text = row.Cells["HargaBeli"].Value.ToString();
                textBox4.Text = row.Cells["HargaJual"].Value.ToString();
                textBox5.Text = row.Cells["JumlahBarang"].Value.ToString();
                comboBox1.Text = row.Cells["SatuanBarang"].Value.ToString();
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text.Trim() == "0")
            {
                MessageBox.Show("Jumlah Tidak Boleh 0 !");
                textBox5.Focus();
            }
            else if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO TBL_Barang values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tambah Data Berhasil !");
                    TampilBarang();
                    Bersihkan();
                    NoOtomatis();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
}
