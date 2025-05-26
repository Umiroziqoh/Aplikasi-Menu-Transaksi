using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Aplikasi_Menu_Transaksi.Views
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=angkringan_food;");

        public Login()
        {
            InitializeComponent();
        }

        private void button1login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM login WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", textBox1username.Text);
                cmd.Parameters.AddWithValue("@password", textBox2password.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Form3 F2 = new Form3();
                    F2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username/Password salah!");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
