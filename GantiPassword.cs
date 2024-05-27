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
    public partial class GantiPassword : Form
    {
        private SqlCommand cmd;

        Koneksi Konn = new Koneksi();

        public GantiPassword()
        {
            InitializeComponent();
        }

        private void GantiPassword_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            textBox2.PasswordChar = '*';
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Masukkan Username Dan Password Baru !");
                }
                else if (textBox1.Text != null && textBox2.Text == "")
                {
                    MessageBox.Show("Masukkan Password Baru");
                }
                else if (textBox1.Text == "" && textBox2.Text != null)
                {
                    MessageBox.Show("Masukkan Username !");
                }
                else
                {
                    SqlDataReader rd;
                    cmd = new SqlCommand("SELECT * FROM TBL_Kasir where UsernameKasir='" + textBox1.Text + "'", conn);
                    conn.Open();
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        conn.Close();
                        cmd = new SqlCommand("UPDATE TBL_Kasir SET PasswordKasir='" + textBox2.Text + "' where Usernamekasir='" + textBox1.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ganti Password Berhasil !");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username Tidak Terdaftar !");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
