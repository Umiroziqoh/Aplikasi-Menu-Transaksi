namespace Aplikasi_Menu_Transaksi.Views
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1Username = new Label();
            label2password = new Label();
            textBox1username = new TextBox();
            textBox2password = new TextBox();
            button1login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1Username
            // 
            label1Username.AutoSize = true;
            label1Username.ForeColor = Color.FromArgb(91, 34, 13);
            label1Username.Location = new Point(66, 307);
            label1Username.Name = "label1Username";
            label1Username.Size = new Size(91, 25);
            label1Username.TabIndex = 0;
            label1Username.Text = "Username";
            // 
            // label2password
            // 
            label2password.AutoSize = true;
            label2password.ForeColor = Color.FromArgb(91, 34, 13);
            label2password.Location = new Point(66, 369);
            label2password.Name = "label2password";
            label2password.Size = new Size(87, 25);
            label2password.TabIndex = 1;
            label2password.Text = "Password";
            // 
            // textBox1username
            // 
            textBox1username.Location = new Point(246, 307);
            textBox1username.Name = "textBox1username";
            textBox1username.Size = new Size(150, 31);
            textBox1username.TabIndex = 2;
            // 
            // textBox2password
            // 
            textBox2password.Location = new Point(246, 369);
            textBox2password.Name = "textBox2password";
            textBox2password.Size = new Size(150, 31);
            textBox2password.TabIndex = 3;
            // 
            // button1login
            // 
            button1login.BackColor = Color.FromArgb(210, 111, 34);
            button1login.ForeColor = Color.White;
            button1login.Location = new Point(284, 431);
            button1login.Name = "button1login";
            button1login.Size = new Size(112, 34);
            button1login.TabIndex = 4;
            button1login.Text = "Login";
            button1login.UseVisualStyleBackColor = false;
            button1login.Click += button1login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 219, 164);
            ClientSize = new Size(467, 519);
            Controls.Add(pictureBox1);
            Controls.Add(button1login);
            Controls.Add(textBox2password);
            Controls.Add(textBox1username);
            Controls.Add(label2password);
            Controls.Add(label1Username);
            Name = "Login";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1Username;
        private Label label2password;
        private TextBox textBox1username;
        private TextBox textBox2password;
        private Button button1login;
        private PictureBox pictureBox1;
    }
}