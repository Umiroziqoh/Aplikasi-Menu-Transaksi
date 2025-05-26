using System;
using System.Windows.Forms;
using Aplikasi_Menu_Transaksi.Models;


namespace Aplikasi_Menu_Transaksi.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jm.Items.Add("Seafood");
            jm.Items.Add("Daging");
            jm.Items.Add("Ayam");
        }

        private void jm_SelectedIndexChanged(object sender, EventArgs e)
        {
            nm.Items.Clear();

            if (jm.Text == "Seafood")
            {
                nm.Items.AddRange(new string[] {
                    "Kerang", "Lobster", "Udang", "Sate Cumi", "Udang Goreng", "Kerang Rebus",
                    "Kerang Saus Pedas", "Tahu Isi Udang", "Lumpia Udang", "Bakwan Cumi", "Sate Udang"
                });
            }
            else if (jm.Text == "Daging")
            {
                nm.Items.AddRange(new string[] {
                    "Rendang", "Steak", "Daging Bakar", "Sate Sapi", "Sate Usus",
                    "Sate Ati Ampela", "Sate Daging Sapi", "Sate Telur Puyuh"
                });
            }
            else if (jm.Text == "Ayam")
            {
                nm.Items.AddRange(new string[] {
                    "Ayam Goreng", "Ayam Bakar", "Ayam Geprek", "Kepala Ayam",
                    "Sayap Ayam", "Ceker Ayam"
                });
            }
        }

        private void nm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = nm.Text;
            string hargaMakanan = selectedItem switch
            {
                "Kerang" => "8000",
                "Lobster" => "7000",
                "Udang" => "9000",
                "Sate Cumi" => "5000",
                "Udang Goreng" => "5000",
                "Kerang Rebus" => "8000",
                "Kerang Saus Pedas" => "10000",
                "Tahu Isi Udang" => "4000",
                "Lumpia Udang" => "4000",
                "Bakwan Cumi" => "4000",
                "Sate Udang" => "3000",
                "Rendang" => "5000",
                "Steak" => "15000",
                "Daging Bakar" => "86000",
                "Sate Sapi" => "5000",
                "Sate Usus" => "3000",
                "Sate Ati Ampela" => "4000",
                "Sate Daging Sapi" => "6000",
                "Sate Telur Puyuh" => "4000",
                "Ayam Goreng" => "18000",
                "Ayam Bakar" => "15000",
                "Ayam Geprek" => "17000",
                "Kepala Ayam" => "5000",
                "Sayap Ayam" => "5000",
                "Ceker Ayam" => "5000",
                _ => "-"
            };

            harga1.Text = hargaMakanan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalharga.Text = (Convert.ToInt32(harga1.Text) * Convert.ToInt32(jumlah1.Text)).ToString();
            potongan1.Text = Convert.ToInt32(totalharga.Text) > 500000 ? "50000" : "0";
            totalbayar1.Text = (Convert.ToInt32(totalharga.Text) - Convert.ToInt32(potongan1.Text)).ToString();

            bool sukses = CrudTransaksiPesanan.Simpan(
                textBox3nonota.Text,
                textBox1namapelanggan.Text,
                dateTimePicker1.Value,
                jm.Text,
                nm.Text,
                harga1.Text,
                jumlah1.Text,
                totalharga.Text,
                potongan1.Text,
                totalbayar1.Text
            );

            if (sukses)
            {
                MessageBox.Show("Data transaksi berhasil disimpan!");
                dataGridView1.Rows.Add(
                    textBox3nonota.Text,
                    textBox1namapelanggan.Text,
                    dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    jm.Text,
                    nm.Text,
                    harga1.Text,
                    jumlah1.Text,
                    totalharga.Text,
                    potongan1.Text,
                    totalbayar1.Text
                );
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3nonota.Clear();
            textBox1namapelanggan.Clear();
            jm.Text = "";
            nm.Text = "";
            harga1.Text = "";
            jumlah1.Text = "";
            totalharga.Text = "";
            potongan1.Text = "";
            totalbayar1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                textBox3nonota.Text = row.Cells["No_Nota"].Value?.ToString();
                textBox1namapelanggan.Text = row.Cells["Nama_Pelanggan"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["Tanggal_Transaksi"].Value?.ToString(), out DateTime tanggal))
                {
                    dateTimePicker1.Value = tanggal;
                }
                jm.Text = row.Cells["Jenis_Makanan"].Value?.ToString();
                nm.Text = row.Cells["Nama_Makanan"].Value?.ToString();
                harga1.Text = row.Cells["Harga"].Value?.ToString();
                jumlah1.Text = row.Cells["Jumlah"].Value?.ToString();
                totalharga.Text = row.Cells["Total_Harga"].Value?.ToString();
                potongan1.Text = row.Cells["Potongan"].Value?.ToString();
                totalbayar1.Text = row.Cells["Total_Bayar"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Silakan pilih baris data yang ingin diedit!");
            }
        }

        private void button5update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                string noNotaLama = dataGridView1.CurrentRow.Cells["No_Nota"].Value.ToString();

                bool berhasil = CrudTransaksiPesanan.Update(
                    noNotaLama,
                    textBox1namapelanggan.Text,
                    dateTimePicker1.Value,
                    jm.Text,
                    nm.Text,
                    harga1.Text,
                    jumlah1.Text,
                    totalharga.Text,
                    potongan1.Text,
                    totalbayar1.Text
                );

                if (berhasil)
                {
                    DataGridViewRow row = dataGridView1.CurrentRow;

                    row.Cells["No_Nota"].Value = textBox3nonota.Text;
                    row.Cells["Nama_Pelanggan"].Value = textBox1namapelanggan.Text;
                    row.Cells["Tanggal_Transaksi"].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    row.Cells["Jenis_Makanan"].Value = jm.Text;
                    row.Cells["Nama_Makanan"].Value = nm.Text;
                    row.Cells["Harga"].Value = harga1.Text;
                    row.Cells["Jumlah"].Value = jumlah1.Text;
                    row.Cells["Total_Harga"].Value = totalharga.Text;
                    row.Cells["Potongan"].Value = potongan1.Text;
                    row.Cells["Total_Bayar"].Value = totalbayar1.Text;

                    MessageBox.Show("Data berhasil diupdate ke database!");
                }
                else
                {
                    MessageBox.Show("Data gagal diupdate.");
                }
            }
            else
            {
                MessageBox.Show("Pilih baris pada tabel yang ingin diupdate!");
            }
        }

        private void button6dalate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string noNota = dataGridView1.CurrentRow.Cells["No_Nota"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Yakin ingin menghapus data dengan No Nota: " + noNota + "?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool sukses = CrudTransaksiPesanan.Hapus(noNota);

                    if (sukses)
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        MessageBox.Show("Data berhasil dihapus.");
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan atau gagal dihapus.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.");
            }
        }

        private void textBox4cari_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox4cari.Text.Trim().ToLower();

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool match = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                        {
                            match = true;
                            break;
                        }
                    }
                    row.Visible = match;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat pencarian: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle klik pada cell jika diperlukan
        }
    }
}
