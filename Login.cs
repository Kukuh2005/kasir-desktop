using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;

namespace kasir
{
    public partial class Login : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private DataAdapter da;
        private SqlDataReader rd;

        Koneksi Konn = new Koneksi();
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();

            conn.Open();
            cmd = new SqlCommand("select * from TBL_Kasir where UsernameKasir='" + textBox1.Text + "' and PasswordKasir='" + textBox2.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh Kosong !");
                textBox1.Focus();
            }
            else if (textBox1.Text == "" && textBox2.Text != null)
            {
                MessageBox.Show("Kolom Username tidak boleh kosong !");
                textBox1.Focus();
            }
            else if (textBox2.Text == "" && textBox1.Text != null)
            {
                MessageBox.Show("Kolom Password tidak boleh Kosong !");
                textBox2.Focus();
            }
            else if (reader.Read())
            {
                menuUtama.menu.menuLogin.Enabled = false;
                menuUtama.menu.menuLogout.Enabled = true;
                menuUtama.menu.menuMaster.Enabled = true;
                menuUtama.menu.menuTransaksi.Enabled = true;
                menuUtama.menu.menuLaporan.Enabled = true;
                menuUtama.menu.menuUtility.Enabled = true;

                this.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Username Atau Password Salah !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            textBox2.PasswordChar = '*';
        }
    }
}