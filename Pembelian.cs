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
using System.Data.SqlClient;

namespace kasir
{
    public partial class Pembelian : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        void Bersihkan()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            comboBox1.Text = "";
            textBox7.Text = "";
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
            textBox2.Text = urutan;
            conn.Close();
        }

        void TampilBarang()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT KodeBarang, NamaBarang, HargaBeli, HargaJual, SatuanBarang FROM TBL_Barang", conn);
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
                cmd = new SqlCommand("SELECT * FROM TBL_Barang where KodeBarang like'%" + textBox7.Text + "%' or NamaBarang like '%" + textBox7.Text + "%' ", conn);
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

        void FakturOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select Faktur from LP_DataMasterBarang where Faktur in(select max(Faktur) from LP_DataMasterBarang) order by Faktur desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["Faktur"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "000" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "000001";
            }
            rd.Close();
            textBox1.Text = urutan;
            conn.Close();
        }

        void satuanCombo()
        {
            comboBox1.Items.Add("PCS");
            comboBox1.Items.Add("KG");
            comboBox1.Items.Add("BOTOL");
            comboBox1.Items.Add("BOX");
        }

        void Rincian()
        {
            dataGridView2.Rows.Add(dateTimePicker1.Value.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text);
        }

        void LaporanBarang()
        {
            SqlConnection conn = Konn.GetConn();
            cmd = new SqlCommand("INSERT INTO LP_DataMasterBarang values('" + textBox1.Text + "', '" + dateTimePicker1.Value.ToString() + "', 'Beli', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox6.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Pembelian()
        {
            InitializeComponent();
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            textBox3.Text = "";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            comboBox1.Text = "";
            textBox7.Text = "";
            NoOtomatis();
            TampilBarang();
            FakturOtomatis();
            satuanCombo();
            textBox2.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox3.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox4.Text = row.Cells["HargaBeli"].Value.ToString();
                textBox5.Text = row.Cells["HargaJual"].Value.ToString();
                textBox6.Text = "0";
                comboBox1.Text = row.Cells["SatuanBarang"].Value.ToString();
                textBox6.Focus();
                TampilBarang();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bersihkan();
            dataGridView2.Rows.Clear();
            FakturOtomatis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            SqlDataReader rd;
            decimal dbJumlah, tambahJumlah, jumlah;

            if(textBox6.Text.Trim() == "")
            {
                MessageBox.Show("Masukkan Jumlah Barang !");
            }
            else if (textBox6.Text.Trim() == "0")
            {
                MessageBox.Show("Jumlah Tidak Boleh 0 !");
            }
            else if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                try
                {
                    LaporanBarang();
                    cmd = new SqlCommand("SELECT * FROM TBL_Barang where KodeBarang='" + textBox2.Text + "'", conn);
                    conn.Open();
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        conn.Close();

                        cmd = new SqlCommand("SELECT JumlahBarang FROM TBL_Barang WHERE KodeBarang='" + textBox2.Text + "'", conn);
                        conn.Open();
                        dbJumlah = (decimal)cmd.ExecuteScalar();
                        conn.Close();

                        jumlah = Convert.ToDecimal(textBox6.Text);
                        tambahJumlah = dbJumlah + jumlah;

                        cmd = new SqlCommand("UPDATE TBL_Barang SET NamaBarang='" + textBox3.Text + "', HargaBeli='" + textBox4.Text + "', HargaJual='" + textBox5.Text + "', JumlahBarang='" + tambahJumlah + "', SatuanBarang='" + comboBox1.Text + "' where KodeBarang='" + textBox2.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Rincian();
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        cmd = new SqlCommand("INSERT INTO TBL_Barang values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Rincian();
                        conn.Close();
                    }
                    Bersihkan();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
}
