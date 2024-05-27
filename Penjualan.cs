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
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kasir
{
    public partial class Penjualan : Form
    {
        public static Penjualan penjualan;
        decimal jumlah, harga, total, tambahtotal, hapusjumlah, hapusharga, hapustotal, sethapus;
        int index;
        string deljumlah, delharga;
        Pembayaran pembayaran;
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public Penjualan()
        {
            InitializeComponent();
        }

        void pembayaran_closed(object sender, FormClosedEventArgs e)
        {
            pembayaran = null;
        }

        void TampilBarang()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                jumlah = 2;
                cmd = new SqlCommand("SELECT KodeBarang, NamaBarang, HargaJual FROM TBL_Barang where JumlahBarang >= '"+ jumlah +"'", conn);
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
                cmd = new SqlCommand("SELECT KodeBarang, NamaBarang, HargaJual FROM TBL_Barang where KodeBarang like'%" + textBox1.Text + "%'", conn);
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

        void Bersihkan()
        {
            textBox1.Text = "";
            label3.Text = "0";
            dataGridView1.DataSource = null;
            dataGridView2.Rows.Clear();
            button6.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            FakturOtomatis();
        }

        void Total()
        {
            label3.Text = Convert.ToString(total);
            penjualan = this;
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
            textBox6.Text = urutan;
            conn.Close();
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            button6.Enabled = false;
            FakturOtomatis();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TampilBarang();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox3.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox4.Text = "1";
                textBox5.Text = row.Cells["HargaJual"].Value.ToString();
                label5.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                textBox4.Enabled = true;
                textBox4.Focus();
                button1.Enabled = true;
                button2.Enabled = true;
                textBox1.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Masukkan Jumlah Barang !");
                textBox4.Focus();
            }
            else if (textBox4.Text.Trim() == "0")
            {
                MessageBox.Show("Jumlah Barang tidak boleh kurang dari 1");
                textBox4.Focus();
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    jumlah = Convert.ToDecimal(textBox4.Text);
                    harga = Convert.ToDecimal(textBox5.Text);
                    total = jumlah * harga;
                    tambahtotal = Convert.ToDecimal(label3.Text);

                    if (label3.Text == "0")
                    {
                        label3.Text = Convert.ToString(total);
                    }
                    else
                    {
                        label3.Text = "";
                        total = tambahtotal + total;
                        label3.Text += Convert.ToString(total);
                    }
                    dataGridView2.Rows.Add(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    textBox4.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button3.Focus();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            textBox4.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox4.Text.Trim() == "")
                {
                    MessageBox.Show("Masukkan Jumlah Barang !");
                    textBox4.Focus();
                }
                else if(textBox4.Text.Trim() == "0")
                {
                    MessageBox.Show("Jumlah Barang tidak boleh kurang dari 1");
                    textBox4.Focus();
                }
                else
                {
                    SqlConnection conn = Konn.GetConn();
                    try
                    {
                        jumlah = Convert.ToDecimal(textBox4.Text);
                        harga = Convert.ToDecimal(textBox5.Text);
                        total = jumlah * harga;
                        tambahtotal = Convert.ToDecimal(label3.Text);

                        if (label3.Text == "0")
                        {
                            Total();
                        }
                        else
                        {
                            label3.Text = "";
                            total = tambahtotal + total;
                            label3.Text += Convert.ToString(total);
                        }

                        dataGridView2.Rows.Add(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        label5.Enabled = false;
                        label6.Enabled = false;
                        label7.Enabled = false;
                        label8.Enabled = false;
                        textBox4.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button3.Focus();

                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            if (MessageBox.Show("Lanjut Bayar ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pembayaran == null)
                {
                    pembayaran = new Pembayaran(this);
                    pembayaran.FormClosed += new FormClosedEventHandler(pembayaran_closed);
                    pembayaran.ShowDialog();
                }
                else
                {
                    pembayaran.Activate();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal perhitunganhapus;
            int rowIndex = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows.RemoveAt(rowIndex);
            hapusjumlah = Convert.ToDecimal(deljumlah);
            hapusharga = Convert.ToDecimal(delharga);
            hapustotal = Convert.ToDecimal(label3.Text);

            perhitunganhapus = hapusjumlah * hapusharga;
            sethapus = hapustotal - perhitunganhapus;
            label3.Text = Convert.ToString(sethapus);
            button6.Enabled = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[index];
            deljumlah = row.Cells[2].Value.ToString();
            delharga = row.Cells[3].Value.ToString();
            button6.Enabled = true;
        }
    }
}
