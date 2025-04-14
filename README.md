# Aplikasi-Menu-Transaksi
Angkringan Food adalah sebuah aplikasi desktop berbasis Windows Forms (WinForms) yang dikembangkan dengan bahasa pemrograman C#. Aplikasi ini dibuat untuk mempermudah proses transaksi penjualan makanan pada sebuah usaha kuliner bernama Angkringan Food.

Fitur-Fitur Utama:

1. Input Transaksi
   * Tanggal Transaksi:
     Menggunakan DateTimePicker agar pengguna dapat memilih tanggal transaksi dengan mudah.
   * No. Nota:
     Input manual untuk mencatat nomor nota transaksi.
2. Pemilihan Menu
   * Jenis Makanan (ComboBox)
     Menyediakan pilihan kategori: Seafood, Daging, dan Ayam.
   * Nama Makanan (ComboBox)
     Otomatis berubah sesuai jenis makanan yang dipilih.
     Contoh: Jika pilih “Ayam”, maka opsi: Ayam Bakar, Ayam Goreng, dll.
   * Harga (TextBox)
     Akan terisi otomatis sesuai pilihan nama makanan.
   * Jumlah (TextBox)
     Diisi secara manual oleh pengguna.
3. Perhitungan Otomatis
   * Total Harga (TextBox)
     Dihitung dari harga * jumlah.
   * Potongan Harga (TextBox)
     Jika total harga lebih dari 500.000, otomatis potongan sebesar 50.000.
   * Total Bayar (TextBox)
     Total harga dikurangi potongan.
4. Tombol Aksi
   * HITUNG (Button): Menghitung total harga dan potongan
   * BERSIH (Button): Mengosongkan seluruh form
   * KELUAR (Button): Menutup aplikasi
5. Visual Pendukung
   * PicturBox: Gambar gerobak angkringan untuk memperkuat nuansa lokal
   
 ![image alt](https://github.com/Umiroziqoh/Aplikasi-Menu-Transaksi/blob/a1760f62d73bb44c9275eb63ad71de69b890a346/Cuplikan%20layar%202025-04-14%20080952.png)
