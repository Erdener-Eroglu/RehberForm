namespace RehberForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtWebAdres = new TextBox();
            txtAdres = new TextBox();
            txtTelefon1 = new TextBox();
            txtTelefon2 = new TextBox();
            txtAçıklama = new TextBox();
            lstKisiler = new ListBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 25);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 62);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefon1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 62);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "Telefon2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 100);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 0;
            label5.Text = "E-Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 99);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 0;
            label6.Text = "WebAdres:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 176);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Açıklama:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 138);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 0;
            label8.Text = "Adres:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(117, 22);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(147, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(367, 21);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(147, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(147, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtWebAdres
            // 
            txtWebAdres.Location = new Point(367, 92);
            txtWebAdres.Name = "txtWebAdres";
            txtWebAdres.Size = new Size(147, 27);
            txtWebAdres.TabIndex = 5;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(117, 135);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(397, 27);
            txtAdres.TabIndex = 6;
            // 
            // txtTelefon1
            // 
            txtTelefon1.Location = new Point(117, 55);
            txtTelefon1.Name = "txtTelefon1";
            txtTelefon1.Size = new Size(147, 27);
            txtTelefon1.TabIndex = 2;
            // 
            // txtTelefon2
            // 
            txtTelefon2.Location = new Point(367, 59);
            txtTelefon2.Name = "txtTelefon2";
            txtTelefon2.Size = new Size(147, 27);
            txtTelefon2.TabIndex = 3;
            // 
            // txtAçıklama
            // 
            txtAçıklama.Location = new Point(117, 173);
            txtAçıklama.Multiline = true;
            txtAçıklama.Name = "txtAçıklama";
            txtAçıklama.Size = new Size(397, 76);
            txtAçıklama.TabIndex = 7;
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 20;
            lstKisiler.Location = new Point(540, 22);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(230, 304);
            lstKisiler.TabIndex = 11;
            lstKisiler.SelectedIndexChanged += lstKisiler_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(117, 266);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(119, 69);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(256, 266);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(119, 69);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(395, 266);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 69);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 389);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstKisiler);
            Controls.Add(txtWebAdres);
            Controls.Add(txtAçıklama);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon2);
            Controls.Add(txtTelefon1);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtWebAdres;
        private TextBox txtAdres;
        private TextBox txtTelefon1;
        private TextBox txtTelefon2;
        private TextBox txtAçıklama;
        private ListBox lstKisiler;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
    }
}