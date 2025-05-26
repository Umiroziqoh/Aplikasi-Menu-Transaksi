namespace Aplikasi_Menu_Transaksi.Views
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2jenismakanan = new Label();
            label3namamakanan = new Label();
            label4harga = new Label();
            label5jumlah = new Label();
            dateTimePicker1 = new DateTimePicker();
            jm = new ComboBox();
            nm = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            harga1 = new TextBox();
            jumlah1 = new TextBox();
            textBox3nonota = new TextBox();
            label6nonota = new Label();
            totalharga = new TextBox();
            label7 = new Label();
            potongan1 = new TextBox();
            label8potongan = new Label();
            totalbayar1 = new TextBox();
            label9totalbayar = new Label();
            button3keluar = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            textBox1namapelanggan = new TextBox();
            label12namapelanggan = new Label();
            button5update = new Button();
            textBox4cari = new TextBox();
            label14cari = new Label();
            dataGridView1 = new DataGridView();
            No_Nota = new DataGridViewTextBoxColumn();
            Nama_Pelanggan = new DataGridViewTextBoxColumn();
            Tanggal_Transaksi = new DataGridViewTextBoxColumn();
            Jenis_Makanan = new DataGridViewTextBoxColumn();
            Nama_Makanan = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            Total_Harga = new DataGridViewTextBoxColumn();
            Potongan = new DataGridViewTextBoxColumn();
            Total_Bayar = new DataGridViewTextBoxColumn();
            button6delete = new Button();
            button3edit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(91, 34, 13);
            label1.Location = new Point(33, 207);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 0;
            label1.Text = "TANGGAL TRANSAKSI";
            // 
            // label2jenismakanan
            // 
            label2jenismakanan.AutoSize = true;
            label2jenismakanan.ForeColor = Color.FromArgb(91, 34, 13);
            label2jenismakanan.Location = new Point(33, 261);
            label2jenismakanan.Name = "label2jenismakanan";
            label2jenismakanan.Size = new Size(148, 25);
            label2jenismakanan.TabIndex = 1;
            label2jenismakanan.Text = "JENIS MAKANAN";
            // 
            // label3namamakanan
            // 
            label3namamakanan.AutoSize = true;
            label3namamakanan.ForeColor = Color.FromArgb(91, 34, 13);
            label3namamakanan.Location = new Point(33, 316);
            label3namamakanan.Name = "label3namamakanan";
            label3namamakanan.Size = new Size(158, 25);
            label3namamakanan.TabIndex = 2;
            label3namamakanan.Text = "NAMA MAKANAN";
            // 
            // label4harga
            // 
            label4harga.AutoSize = true;
            label4harga.ForeColor = Color.FromArgb(91, 34, 13);
            label4harga.Location = new Point(33, 379);
            label4harga.Name = "label4harga";
            label4harga.Size = new Size(72, 25);
            label4harga.TabIndex = 3;
            label4harga.Text = "HARGA";
            // 
            // label5jumlah
            // 
            label5jumlah.AutoSize = true;
            label5jumlah.ForeColor = Color.FromArgb(91, 34, 13);
            label5jumlah.Location = new Point(33, 439);
            label5jumlah.Name = "label5jumlah";
            label5jumlah.Size = new Size(80, 25);
            label5jumlah.TabIndex = 4;
            label5jumlah.Text = "JUMLAH";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(91, 31, 11);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(91, 31, 11);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(91, 31, 11);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(91, 31, 11);
            dateTimePicker1.CalendarTrailingForeColor = Color.FromArgb(91, 31, 11);
            dateTimePicker1.Location = new Point(236, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // jm
            // 
            jm.ForeColor = Color.FromArgb(94, 36, 16);
            jm.FormattingEnabled = true;
            jm.Location = new Point(236, 261);
            jm.Name = "jm";
            jm.Size = new Size(194, 33);
            jm.TabIndex = 6;
            jm.SelectedIndexChanged += jm_SelectedIndexChanged;
            // 
            // nm
            // 
            nm.ForeColor = Color.FromArgb(94, 36, 16);
            nm.FormattingEnabled = true;
            nm.Location = new Point(236, 316);
            nm.Name = "nm";
            nm.Size = new Size(194, 33);
            nm.TabIndex = 7;
            nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(210, 111, 34);
            button1.ForeColor = Color.White;
            button1.Location = new Point(318, 502);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "HITUNG";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(210, 111, 34);
            button2.ForeColor = Color.White;
            button2.Location = new Point(154, 502);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "BERSIH";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // harga1
            // 
            harga1.ForeColor = Color.FromArgb(94, 36, 16);
            harga1.Location = new Point(236, 371);
            harga1.Multiline = true;
            harga1.Name = "harga1";
            harga1.Size = new Size(194, 33);
            harga1.TabIndex = 10;
            // 
            // jumlah1
            // 
            jumlah1.ForeColor = Color.FromArgb(94, 36, 16);
            jumlah1.Location = new Point(236, 431);
            jumlah1.Multiline = true;
            jumlah1.Name = "jumlah1";
            jumlah1.Size = new Size(194, 33);
            jumlah1.TabIndex = 11;
            // 
            // textBox3nonota
            // 
            textBox3nonota.ForeColor = Color.FromArgb(94, 36, 16);
            textBox3nonota.Location = new Point(670, 37);
            textBox3nonota.Multiline = true;
            textBox3nonota.Name = "textBox3nonota";
            textBox3nonota.Size = new Size(194, 33);
            textBox3nonota.TabIndex = 13;
            // 
            // label6nonota
            // 
            label6nonota.AutoSize = true;
            label6nonota.ForeColor = Color.FromArgb(91, 34, 13);
            label6nonota.Location = new Point(489, 37);
            label6nonota.Name = "label6nonota";
            label6nonota.Size = new Size(94, 25);
            label6nonota.TabIndex = 12;
            label6nonota.Text = "NO. NOTA";
            // 
            // totalharga
            // 
            totalharga.ForeColor = Color.FromArgb(94, 36, 16);
            totalharga.Location = new Point(685, 414);
            totalharga.Multiline = true;
            totalharga.Name = "totalharga";
            totalharga.Size = new Size(194, 33);
            totalharga.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(91, 34, 13);
            label7.Location = new Point(504, 414);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 14;
            label7.Text = "TOTAL HARGA";
            // 
            // potongan1
            // 
            potongan1.ForeColor = Color.FromArgb(94, 36, 16);
            potongan1.Location = new Point(685, 466);
            potongan1.Multiline = true;
            potongan1.Name = "potongan1";
            potongan1.Size = new Size(194, 33);
            potongan1.TabIndex = 17;
            // 
            // label8potongan
            // 
            label8potongan.AutoSize = true;
            label8potongan.ForeColor = Color.FromArgb(91, 34, 13);
            label8potongan.Location = new Point(504, 466);
            label8potongan.Name = "label8potongan";
            label8potongan.Size = new Size(107, 25);
            label8potongan.TabIndex = 16;
            label8potongan.Text = "POTONGAN";
            // 
            // totalbayar1
            // 
            totalbayar1.Location = new Point(685, 518);
            totalbayar1.Multiline = true;
            totalbayar1.Name = "totalbayar1";
            totalbayar1.Size = new Size(194, 33);
            totalbayar1.TabIndex = 19;
            // 
            // label9totalbayar
            // 
            label9totalbayar.AutoSize = true;
            label9totalbayar.ForeColor = Color.FromArgb(91, 34, 13);
            label9totalbayar.Location = new Point(504, 518);
            label9totalbayar.Name = "label9totalbayar";
            label9totalbayar.Size = new Size(119, 25);
            label9totalbayar.TabIndex = 18;
            label9totalbayar.Text = "TOTAL BAYAR";
            // 
            // button3keluar
            // 
            button3keluar.BackColor = Color.FromArgb(210, 111, 34);
            button3keluar.ForeColor = Color.White;
            button3keluar.Location = new Point(767, 573);
            button3keluar.Name = "button3keluar";
            button3keluar.Size = new Size(112, 34);
            button3keluar.TabIndex = 20;
            button3keluar.Text = "KELUAR";
            button3keluar.UseVisualStyleBackColor = false;
            button3keluar.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(535, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(91, 34, 13);
            label10.Location = new Point(33, 76);
            label10.Name = "label10";
            label10.Size = new Size(407, 54);
            label10.TabIndex = 22;
            label10.Text = "ANGKRINGAN FOOD";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(91, 34, 13);
            label11.Location = new Point(21, 582);
            label11.Name = "label11";
            label11.Size = new Size(485, 25);
            label11.TabIndex = 23;
            label11.Text = "Pembelian Di Atas 500 Ribu Dapat Potongan Harga 50 Ribu";
            // 
            // textBox1namapelanggan
            // 
            textBox1namapelanggan.ForeColor = Color.FromArgb(94, 36, 16);
            textBox1namapelanggan.Location = new Point(670, 76);
            textBox1namapelanggan.Multiline = true;
            textBox1namapelanggan.Name = "textBox1namapelanggan";
            textBox1namapelanggan.Size = new Size(194, 33);
            textBox1namapelanggan.TabIndex = 25;
            // 
            // label12namapelanggan
            // 
            label12namapelanggan.AutoSize = true;
            label12namapelanggan.ForeColor = Color.FromArgb(91, 34, 13);
            label12namapelanggan.Location = new Point(489, 79);
            label12namapelanggan.Name = "label12namapelanggan";
            label12namapelanggan.Size = new Size(172, 25);
            label12namapelanggan.TabIndex = 24;
            label12namapelanggan.Text = "NAMA PELANGGAN";
            // 
            // button5update
            // 
            button5update.BackColor = Color.FromArgb(210, 111, 34);
            button5update.ForeColor = Color.White;
            button5update.Location = new Point(207, 634);
            button5update.Name = "button5update";
            button5update.Size = new Size(112, 34);
            button5update.TabIndex = 27;
            button5update.Text = "UPDATE";
            button5update.UseVisualStyleBackColor = false;
            button5update.Click += button5update_Click;
            // 
            // textBox4cari
            // 
            textBox4cari.ForeColor = Color.FromArgb(94, 36, 16);
            textBox4cari.Location = new Point(685, 634);
            textBox4cari.Name = "textBox4cari";
            textBox4cari.Size = new Size(194, 31);
            textBox4cari.TabIndex = 31;
            textBox4cari.TextChanged += textBox4cari_TextChanged;
            // 
            // label14cari
            // 
            label14cari.AutoSize = true;
            label14cari.ForeColor = Color.FromArgb(91, 34, 13);
            label14cari.Location = new Point(601, 634);
            label14cari.Name = "label14cari";
            label14cari.Size = new Size(51, 25);
            label14cari.TabIndex = 30;
            label14cari.Text = "CARI";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(210, 111, 34);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No_Nota, Nama_Pelanggan, Tanggal_Transaksi, Jenis_Makanan, Nama_Makanan, Harga, Jumlah, Total_Harga, Potongan, Total_Bayar });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 682);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(935, 248);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // No_Nota
            // 
            No_Nota.HeaderText = "No_Nota";
            No_Nota.MinimumWidth = 8;
            No_Nota.Name = "No_Nota";
            No_Nota.ReadOnly = true;
            No_Nota.Width = 150;
            // 
            // Nama_Pelanggan
            // 
            Nama_Pelanggan.HeaderText = "Nama_Pelanggan";
            Nama_Pelanggan.MinimumWidth = 8;
            Nama_Pelanggan.Name = "Nama_Pelanggan";
            Nama_Pelanggan.ReadOnly = true;
            Nama_Pelanggan.Width = 150;
            // 
            // Tanggal_Transaksi
            // 
            Tanggal_Transaksi.HeaderText = "Tanggal_Transaksi";
            Tanggal_Transaksi.MinimumWidth = 8;
            Tanggal_Transaksi.Name = "Tanggal_Transaksi";
            Tanggal_Transaksi.ReadOnly = true;
            Tanggal_Transaksi.Width = 150;
            // 
            // Jenis_Makanan
            // 
            Jenis_Makanan.HeaderText = "Jenis_Makanan";
            Jenis_Makanan.MinimumWidth = 8;
            Jenis_Makanan.Name = "Jenis_Makanan";
            Jenis_Makanan.ReadOnly = true;
            Jenis_Makanan.Width = 150;
            // 
            // Nama_Makanan
            // 
            Nama_Makanan.HeaderText = "Nama_Makanan";
            Nama_Makanan.MinimumWidth = 8;
            Nama_Makanan.Name = "Nama_Makanan";
            Nama_Makanan.ReadOnly = true;
            Nama_Makanan.Width = 150;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 8;
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            Harga.Width = 150;
            // 
            // Jumlah
            // 
            Jumlah.HeaderText = "Jumlah";
            Jumlah.MinimumWidth = 8;
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            Jumlah.Width = 150;
            // 
            // Total_Harga
            // 
            Total_Harga.HeaderText = "Total_Harga";
            Total_Harga.MinimumWidth = 8;
            Total_Harga.Name = "Total_Harga";
            Total_Harga.ReadOnly = true;
            Total_Harga.Width = 150;
            // 
            // Potongan
            // 
            Potongan.HeaderText = "Potongan";
            Potongan.MinimumWidth = 8;
            Potongan.Name = "Potongan";
            Potongan.ReadOnly = true;
            Potongan.Width = 150;
            // 
            // Total_Bayar
            // 
            Total_Bayar.HeaderText = "Total_Bayar";
            Total_Bayar.MinimumWidth = 8;
            Total_Bayar.Name = "Total_Bayar";
            Total_Bayar.ReadOnly = true;
            Total_Bayar.Width = 150;
            // 
            // button6delete
            // 
            button6delete.BackColor = Color.FromArgb(210, 111, 34);
            button6delete.ForeColor = Color.White;
            button6delete.Location = new Point(394, 634);
            button6delete.Name = "button6delete";
            button6delete.Size = new Size(112, 34);
            button6delete.TabIndex = 27;
            button6delete.Text = "DELETE";
            button6delete.UseVisualStyleBackColor = false;
            button6delete.Click += button6dalate_Click;
            // 
            // button3edit
            // 
            button3edit.BackColor = Color.FromArgb(210, 111, 34);
            button3edit.ForeColor = Color.White;
            button3edit.Location = new Point(33, 634);
            button3edit.Name = "button3edit";
            button3edit.Size = new Size(112, 34);
            button3edit.TabIndex = 35;
            button3edit.Text = "EDIT";
            button3edit.UseVisualStyleBackColor = false;
            button3edit.Click += button3edit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 219, 164);
            ClientSize = new Size(935, 930);
            Controls.Add(button3edit);
            Controls.Add(button6delete);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4cari);
            Controls.Add(label14cari);
            Controls.Add(button5update);
            Controls.Add(textBox1namapelanggan);
            Controls.Add(label12namapelanggan);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(button3keluar);
            Controls.Add(totalbayar1);
            Controls.Add(label9totalbayar);
            Controls.Add(potongan1);
            Controls.Add(label8potongan);
            Controls.Add(totalharga);
            Controls.Add(label7);
            Controls.Add(textBox3nonota);
            Controls.Add(label6nonota);
            Controls.Add(jumlah1);
            Controls.Add(harga1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(nm);
            Controls.Add(jm);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5jumlah);
            Controls.Add(label4harga);
            Controls.Add(label3namamakanan);
            Controls.Add(label2jenismakanan);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2jenismakanan;
        private Label label3namamakanan;
        private Label label4harga;
        private Label label5jumlah;
        private DateTimePicker dateTimePicker1;
        private ComboBox jm;
        private ComboBox nm;
        private Button button1;
        private Button button2;
        private TextBox harga1;
        private TextBox jumlah1;
        private TextBox textBox3nonota;
        private Label label6nonota;
        private TextBox totalharga;
        private Label label7;
        private TextBox potongan1;
        private Label label8potongan;
        private TextBox totalbayar1;
        private Label label9totalbayar;
        private Button button3keluar;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label11;
        private TextBox textBox1namapelanggan;
        private Label label12namapelanggan;
        private Button button5update;
        private TextBox textBox4cari;
        private Label label14cari;
        private DataGridView dataGridView1;
        private Button button6delete;
        private DataGridViewTextBoxColumn No_Nota;
        private DataGridViewTextBoxColumn Nama_Pelanggan;
        private DataGridViewTextBoxColumn Tanggal_Transaksi;
        private DataGridViewTextBoxColumn Jenis_Makanan;
        private DataGridViewTextBoxColumn Nama_Makanan;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Total_Harga;
        private DataGridViewTextBoxColumn Potongan;
        private DataGridViewTextBoxColumn Total_Bayar;
        private Button button3edit;
    }
}
