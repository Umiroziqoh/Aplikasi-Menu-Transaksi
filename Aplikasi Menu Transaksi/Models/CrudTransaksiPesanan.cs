using System;
using MySql.Data.MySqlClient;
using Aplikasi_Menu_Transaksi.Models;


namespace Aplikasi_Menu_Transaksi.Models
{
    public class CrudTransaksiPesanan
    {
        private static string connStr = "server=localhost;user=root;password=;database=angkringan_food;";

        public static bool Simpan(
            string noNota, string namaPelanggan, DateTime tanggalTransaksi,
            string jenisMakanan, string namaMakanan, string harga, string jumlah,
            string totalHarga, string potongan, string totalBayar)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO transaksi_pesanan
                        (no_nota, nama_pelanggan, tanggal_transaksi, jenis_makanan, nama_makanan, harga, jumlah, total_harga, potongan, total_bayar) 
                        VALUES 
                        (@no_nota, @nama_pelanggan, @tanggal_transaksi, @jenis_makanan, @nama_makanan, @harga, @jumlah, @total_harga, @potongan, @total_bayar)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@no_nota", noNota);
                        cmd.Parameters.AddWithValue("@nama_pelanggan", namaPelanggan);
                        cmd.Parameters.AddWithValue("@tanggal_transaksi", tanggalTransaksi.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@jenis_makanan", jenisMakanan);
                        cmd.Parameters.AddWithValue("@nama_makanan", namaMakanan);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@total_harga", totalHarga);
                        cmd.Parameters.AddWithValue("@potongan", potongan);
                        cmd.Parameters.AddWithValue("@total_bayar", totalBayar);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Simpan: " + ex.Message);
                return false;
            }
        }

        public static bool Update(
            string noNota, string namaPelanggan, DateTime tanggalTransaksi,
            string jenisMakanan, string namaMakanan, string harga, string jumlah,
            string totalHarga, string potongan, string totalBayar)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"UPDATE transaksi_pesanan SET 
                        nama_pelanggan = @nama_pelanggan,
                        tanggal_transaksi = @tanggal_transaksi,
                        jenis_makanan = @jenis_makanan,
                        nama_makanan = @nama_makanan,
                        harga = @harga,
                        jumlah = @jumlah,
                        total_harga = @total_harga,
                        potongan = @potongan,
                        total_bayar = @total_bayar
                        WHERE no_nota = @no_nota";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@no_nota", noNota);
                        cmd.Parameters.AddWithValue("@nama_pelanggan", namaPelanggan);
                        cmd.Parameters.AddWithValue("@tanggal_transaksi", tanggalTransaksi.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@jenis_makanan", jenisMakanan);
                        cmd.Parameters.AddWithValue("@nama_makanan", namaMakanan);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@total_harga", totalHarga);
                        cmd.Parameters.AddWithValue("@potongan", potongan);
                        cmd.Parameters.AddWithValue("@total_bayar", totalBayar);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Update: " + ex.Message);
                return false;
            }
        }

        public static bool Hapus(string noNota)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "DELETE FROM transaksi_pesanan WHERE no_nota = @no_nota";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@no_nota", noNota);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Hapus: " + ex.Message);
                return false;
            }
        }
    }
}
