using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace kasir
{
    public partial class DataKasir : Form
    {
        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            NoOtomatis();
        }
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeKasir from TBL_Kasir where KodeKasir in(select max(KodeKasir) from TBL_Kasir) order by Kodekasir desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeKasir"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "KSR" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "KSR001";
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
                cmd = new SqlCommand("SELECT * FROM TBL_Kasir", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Kasir");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Kasir";
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

        void CariKasir()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_Kasir where KodeKasir like'%" + textBox5.Text + "%' or UsernameKasir like '%" + textBox5.Text + "%' ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Kasir");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Kasir";
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

        void LevelKasir()
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Kasir");
        }

        public DataKasir()
        {
            InitializeComponent();
        }

        private void DataKasir_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            TampilBarang();
            Bersihkan();
            NoOtomatis();
            LevelKasir();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into TBL_Kasir values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", conn);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["KodeKasir"].Value.ToString();
                textBox2.Text = row.Cells["UsernameKasir"].Value.ToString();
                textBox3.Text = row.Cells["PasswordKasir"].Value.ToString();
                comboBox1.Text = row.Cells["LevelKasir"].Value.ToString();
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update TBL_Kasir set UsernameKasir = '" + textBox2.Text + "',PasswordKasir = '" + textBox3.Text + "',LevelKasir = '" + comboBox1.Text + "' where KodeKasir ='" + textBox1.Text + "'", conn);
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
            if (MessageBox.Show("Yakin ingin menghapus data : " + textBox2.Text + " ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("delete TBL_Kasir  where KodeKasir ='" + textBox1.Text + "' ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus Data Berhasil !");
                    TampilBarang();
                    Bersihkan();
                    NoOtomatis();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bersihkan();
            NoOtomatis();
            CariKasir();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CariKasir();
        }
    }
}
