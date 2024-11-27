namespace veri_transferi
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbIcerikId = new ComboBox();
            cmbIcerikRevId = new ComboBox();
            cmbPrimaryKey = new ComboBox();
            cmbTablo = new ComboBox();
            cmbSema = new ComboBox();
            cmbKatalog = new ComboBox();
            cmbKaynak = new ComboBox();
            groupBox2 = new GroupBox();
            btnKlasorSec = new Button();
            txtKlasor = new TextBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txtDosyaAdiOnEki = new TextBox();
            txtBucketAdi = new TextBox();
            txtSecretAccessKey = new TextBox();
            txtAccessKey = new TextBox();
            txtServisAdresi = new TextBox();
            groupBox4 = new GroupBox();
            btnHataLogKlasoruSec = new Button();
            txtHataLogKlasoru = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cmbCalismaSekli = new ComboBox();
            groupBox5 = new GroupBox();
            btnKontrolEt = new Button();
            btnCreateScript = new Button();
            label8 = new Label();
            cmbSema2 = new ComboBox();
            label9 = new Label();
            cmbTablo2 = new ComboBox();
            btnBaslat = new Button();
            btnDurdur = new Button();
            progressBar = new ProgressBar();
            richTextBox = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbIcerikId);
            groupBox1.Controls.Add(cmbIcerikRevId);
            groupBox1.Controls.Add(cmbPrimaryKey);
            groupBox1.Controls.Add(cmbTablo);
            groupBox1.Controls.Add(cmbSema);
            groupBox1.Controls.Add(cmbKatalog);
            groupBox1.Controls.Add(cmbKaynak);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 277);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veritabanı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 239);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 13;
            label7.Text = "Primary Key:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 205);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "IcerıkRevId:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 171);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 11;
            label5.Text = "IcerıkId:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 137);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 10;
            label4.Text = "Tablo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 103);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Şema:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "Katalog:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 7;
            label1.Text = "Kaynak:";
            // 
            // cmbIcerikId
            // 
            cmbIcerikId.BackColor = SystemColors.ControlLight;
            cmbIcerikId.FormattingEnabled = true;
            cmbIcerikId.Location = new Point(116, 168);
            cmbIcerikId.Name = "cmbIcerikId";
            cmbIcerikId.Size = new Size(227, 28);
            cmbIcerikId.TabIndex = 6;
            cmbIcerikId.SelectedIndexChanged += icerikId_SelectedIndexChanged;
            // 
            // cmbIcerikRevId
            // 
            cmbIcerikRevId.BackColor = SystemColors.ControlLight;
            cmbIcerikRevId.FormattingEnabled = true;
            cmbIcerikRevId.Location = new Point(116, 202);
            cmbIcerikRevId.Name = "cmbIcerikRevId";
            cmbIcerikRevId.Size = new Size(227, 28);
            cmbIcerikRevId.TabIndex = 5;
            cmbIcerikRevId.SelectedIndexChanged += icerikRevId_SelectedIndexChanged;
            // 
            // cmbPrimaryKey
            // 
            cmbPrimaryKey.BackColor = SystemColors.ControlLight;
            cmbPrimaryKey.FormattingEnabled = true;
            cmbPrimaryKey.Location = new Point(116, 236);
            cmbPrimaryKey.Name = "cmbPrimaryKey";
            cmbPrimaryKey.Size = new Size(227, 28);
            cmbPrimaryKey.TabIndex = 4;
            // 
            // cmbTablo
            // 
            cmbTablo.BackColor = SystemColors.ControlLight;
            cmbTablo.FormattingEnabled = true;
            cmbTablo.Location = new Point(116, 134);
            cmbTablo.Name = "cmbTablo";
            cmbTablo.Size = new Size(227, 28);
            cmbTablo.TabIndex = 3;
            cmbTablo.SelectedIndexChanged += tablo_SelectedIndexChanged;
            // 
            // cmbSema
            // 
            cmbSema.BackColor = SystemColors.ControlLight;
            cmbSema.FormattingEnabled = true;
            cmbSema.Location = new Point(116, 100);
            cmbSema.Name = "cmbSema";
            cmbSema.Size = new Size(227, 28);
            cmbSema.TabIndex = 2;
            cmbSema.SelectedIndexChanged += sema_SelectedIndexChanged;
            // 
            // cmbKatalog
            // 
            cmbKatalog.BackColor = SystemColors.ControlLight;
            cmbKatalog.FormattingEnabled = true;
            cmbKatalog.Location = new Point(116, 66);
            cmbKatalog.Name = "cmbKatalog";
            cmbKatalog.Size = new Size(227, 28);
            cmbKatalog.TabIndex = 1;
            cmbKatalog.SelectedIndexChanged += katalog_SelectedIndexChanged;
            // 
            // cmbKaynak
            // 
            cmbKaynak.BackColor = SystemColors.ControlLight;
            cmbKaynak.FormattingEnabled = true;
            cmbKaynak.Items.AddRange(new object[] { "localhost" });
            cmbKaynak.Location = new Point(116, 32);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Size = new Size(227, 28);
            cmbKaynak.TabIndex = 0;
            cmbKaynak.SelectedIndexChanged += kaynak_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(btnKlasorSec);
            groupBox2.Controls.Add(txtKlasor);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(411, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(686, 94);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wcc Bağlantı Bilgileri";
            // 
            // btnKlasorSec
            // 
            btnKlasorSec.Location = new Point(557, 30);
            btnKlasorSec.Name = "btnKlasorSec";
            btnKlasorSec.Size = new Size(102, 29);
            btnKlasorSec.TabIndex = 22;
            btnKlasorSec.Text = "Seç";
            btnKlasorSec.UseVisualStyleBackColor = true;
            btnKlasorSec.Click += klasor_sec_Click;
            // 
            // txtKlasor
            // 
            txtKlasor.BackColor = SystemColors.Control;
            txtKlasor.Location = new Point(149, 32);
            txtKlasor.Name = "txtKlasor";
            txtKlasor.Size = new Size(402, 27);
            txtKlasor.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(90, 34);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 20;
            label13.Text = "Klasör:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtDosyaAdiOnEki);
            groupBox3.Controls.Add(txtBucketAdi);
            groupBox3.Controls.Add(txtSecretAccessKey);
            groupBox3.Controls.Add(txtAccessKey);
            groupBox3.Controls.Add(txtServisAdresi);
            groupBox3.Location = new Point(411, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(686, 204);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "S3 Bağlantı Bilgileri";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(155, 161);
            label20.Name = "label20";
            label20.Size = new Size(42, 20);
            label20.TabIndex = 32;
            label20.Text = "icbk-";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 158);
            label19.Name = "label19";
            label19.Size = new Size(126, 20);
            label19.TabIndex = 32;
            label19.Text = "Dosya Adı Ön Eki:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(60, 125);
            label18.Name = "label18";
            label18.Size = new Size(83, 20);
            label18.TabIndex = 33;
            label18.Text = "Bucket Adı:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 95);
            label17.Name = "label17";
            label17.Size = new Size(129, 20);
            label17.TabIndex = 32;
            label17.Text = "Secret Access Key:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(59, 62);
            label16.Name = "label16";
            label16.Size = new Size(84, 20);
            label16.TabIndex = 31;
            label16.Text = "Access Key:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 29);
            label15.Name = "label15";
            label15.Size = new Size(96, 20);
            label15.TabIndex = 30;
            label15.Text = "Servis Adresi:";
            // 
            // txtDosyaAdiOnEki
            // 
            txtDosyaAdiOnEki.BackColor = SystemColors.Window;
            txtDosyaAdiOnEki.Location = new Point(203, 158);
            txtDosyaAdiOnEki.Name = "txtDosyaAdiOnEki";
            txtDosyaAdiOnEki.PlaceholderText = "[UygulamaKısaAdi] Örn.: pys, liman, ebys vb. ";
            txtDosyaAdiOnEki.Size = new Size(465, 27);
            txtDosyaAdiOnEki.TabIndex = 29;
            // 
            // txtBucketAdi
            // 
            txtBucketAdi.BackColor = SystemColors.Window;
            txtBucketAdi.Location = new Point(149, 125);
            txtBucketAdi.Name = "txtBucketAdi";
            txtBucketAdi.Size = new Size(519, 27);
            txtBucketAdi.TabIndex = 28;
            // 
            // txtSecretAccessKey
            // 
            txtSecretAccessKey.BackColor = SystemColors.Window;
            txtSecretAccessKey.Location = new Point(149, 92);
            txtSecretAccessKey.Name = "txtSecretAccessKey";
            txtSecretAccessKey.Size = new Size(519, 27);
            txtSecretAccessKey.TabIndex = 27;
            // 
            // txtAccessKey
            // 
            txtAccessKey.BackColor = SystemColors.Window;
            txtAccessKey.Location = new Point(149, 59);
            txtAccessKey.Name = "txtAccessKey";
            txtAccessKey.Size = new Size(519, 27);
            txtAccessKey.TabIndex = 26;
            // 
            // txtServisAdresi
            // 
            txtServisAdresi.BackColor = SystemColors.Window;
            txtServisAdresi.Location = new Point(149, 26);
            txtServisAdresi.Name = "txtServisAdresi";
            txtServisAdresi.Size = new Size(519, 27);
            txtServisAdresi.TabIndex = 25;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonFace;
            groupBox4.Controls.Add(btnHataLogKlasoruSec);
            groupBox4.Controls.Add(txtHataLogKlasoru);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(cmbCalismaSekli);
            groupBox4.Location = new Point(411, 385);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(686, 129);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Çalışma Parametreleri";
            // 
            // btnHataLogKlasoruSec
            // 
            btnHataLogKlasoruSec.Location = new Point(566, 82);
            btnHataLogKlasoruSec.Name = "btnHataLogKlasoruSec";
            btnHataLogKlasoruSec.Size = new Size(102, 29);
            btnHataLogKlasoruSec.TabIndex = 20;
            btnHataLogKlasoruSec.Text = "Seç";
            btnHataLogKlasoruSec.UseVisualStyleBackColor = true;
            btnHataLogKlasoruSec.Click += hata_log_sec_Click;
            // 
            // txtHataLogKlasoru
            // 
            txtHataLogKlasoru.BackColor = SystemColors.Control;
            txtHataLogKlasoru.Location = new Point(149, 84);
            txtHataLogKlasoru.Name = "txtHataLogKlasoru";
            txtHataLogKlasoru.Size = new Size(402, 27);
            txtHataLogKlasoru.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 87);
            label11.Name = "label11";
            label11.Size = new Size(126, 20);
            label11.TabIndex = 18;
            label11.Text = "Hata Log Klasörü:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 44);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 17;
            label10.Text = "Çalışma Şekli:";
            // 
            // cmbCalismaSekli
            // 
            cmbCalismaSekli.BackColor = SystemColors.ControlLight;
            cmbCalismaSekli.FormattingEnabled = true;
            cmbCalismaSekli.Items.AddRange(new object[] { "Hata Olustugunda Durdur", "Hata Olustugunda Devam Et" });
            cmbCalismaSekli.Location = new Point(149, 41);
            cmbCalismaSekli.Name = "cmbCalismaSekli";
            cmbCalismaSekli.Size = new Size(519, 28);
            cmbCalismaSekli.TabIndex = 15;
            cmbCalismaSekli.SelectedIndexChanged += cmbCalismaSekli_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonFace;
            groupBox5.Controls.Add(btnKontrolEt);
            groupBox5.Controls.Add(btnCreateScript);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(cmbSema2);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(cmbTablo2);
            groupBox5.Location = new Point(12, 295);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(366, 145);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Log Şema ve Tablo";
            // 
            // btnKontrolEt
            // 
            btnKontrolEt.Location = new Point(229, 100);
            btnKontrolEt.Name = "btnKontrolEt";
            btnKontrolEt.Size = new Size(114, 29);
            btnKontrolEt.TabIndex = 19;
            btnKontrolEt.Text = "Kontrol Et";
            btnKontrolEt.UseVisualStyleBackColor = true;
            btnKontrolEt.Click += kontrol_et_button_Click;
            // 
            // btnCreateScript
            // 
            btnCreateScript.Location = new Point(116, 100);
            btnCreateScript.Name = "btnCreateScript";
            btnCreateScript.Size = new Size(107, 29);
            btnCreateScript.TabIndex = 18;
            btnCreateScript.Text = "Create Script";
            btnCreateScript.UseVisualStyleBackColor = true;
            btnCreateScript.Click += create_script_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 66);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 17;
            label8.Text = "Tablo:";
            // 
            // cmbSema2
            // 
            cmbSema2.BackColor = SystemColors.ControlLight;
            cmbSema2.FormattingEnabled = true;
            cmbSema2.Location = new Point(116, 29);
            cmbSema2.Name = "cmbSema2";
            cmbSema2.Size = new Size(227, 28);
            cmbSema2.TabIndex = 14;
            cmbSema2.SelectedIndexChanged += sema2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 29);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 16;
            label9.Text = "Şema:";
            // 
            // cmbTablo2
            // 
            cmbTablo2.BackColor = SystemColors.ControlLight;
            cmbTablo2.FormattingEnabled = true;
            cmbTablo2.Location = new Point(116, 66);
            cmbTablo2.Name = "cmbTablo2";
            cmbTablo2.Size = new Size(227, 28);
            cmbTablo2.TabIndex = 15;
            cmbTablo2.SelectedIndexChanged += tablo2_SelectedIndexChanged;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(12, 446);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(366, 29);
            btnBaslat.TabIndex = 7;
            btnBaslat.Text = "Veri Transferi Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += baslat_button_Click;
            // 
            // btnDurdur
            // 
            btnDurdur.Location = new Point(12, 485);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(366, 29);
            btnDurdur.TabIndex = 8;
            btnDurdur.Text = "Veri Transferi Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            btnDurdur.Click += btnDurdur_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 529);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1085, 29);
            progressBar.TabIndex = 9;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = SystemColors.WindowText;
            richTextBox.ForeColor = SystemColors.Window;
            richTextBox.Location = new Point(12, 564);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(1085, 264);
            richTextBox.TabIndex = 10;
            richTextBox.Text = "";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1109, 850);
            Controls.Add(richTextBox);
            Controls.Add(progressBar);
            Controls.Add(btnDurdur);
            Controls.Add(btnBaslat);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "WCC To S3 Veri Transferi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button btnBaslat;
        private Button btnDurdur;
        private ComboBox cmbTablo;
        private ComboBox cmbSema;
        private ComboBox cmbKatalog;
        private ComboBox cmbKaynak;
        private Label label1;
        private ComboBox cmbIcerikId;
        private ComboBox cmbIcerikRevId;
        private ComboBox cmbPrimaryKey;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCreateScript;
        private Label label8;
        private ComboBox cmbSema2;
        private Label label9;
        private ComboBox cmbTablo2;
        private Button btnHataLogKlasoruSec;
        private TextBox txtHataLogKlasoru;
        private Label label11;
        private Label label10;
        private ComboBox cmbCalismaSekli;
        private Button btnKontrolEt;
        private Label label13;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtDosyaAdiOnEki;
        private TextBox txtBucketAdi;
        private TextBox txtSecretAccessKey;
        private TextBox txtAccessKey;
        private TextBox txtServisAdresi;
        private Label label20;
        private ProgressBar progressBar;
        private RichTextBox richTextBox;
        private Button btnKlasorSec;
        private TextBox txtKlasor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
