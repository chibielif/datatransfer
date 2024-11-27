namespace veri_transferi
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            btnOlustur = new Button();
            label4 = new Label();
            label3 = new Label();
            cmbSema = new ComboBox();
            txtTablo = new TextBox();
            rtxtQuery = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOlustur);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbSema);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log Şema ve Tablo";
            // 
            // btnOlustur
            // 
            btnOlustur.Location = new Point(108, 99);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(239, 29);
            btnOlustur.TabIndex = 15;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += olustur_buton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 68);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 14;
            label4.Text = "Tablo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 34);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 13;
            label3.Text = "Şema:";
            // 
            // cmbSema
            // 
            cmbSema.BackColor = SystemColors.ControlLight;
            cmbSema.FormattingEnabled = true;
            cmbSema.Location = new Point(108, 31);
            cmbSema.Name = "cmbSema";
            cmbSema.Size = new Size(239, 28);
            cmbSema.TabIndex = 11;
            cmbSema.SelectedIndexChanged += sema_SelectedIndexChanged;
            // 
            // txtTablo
            // 
            txtTablo.BackColor = SystemColors.Window;
            txtTablo.Location = new Point(120, 78);
            txtTablo.Name = "txtTablo";
            txtTablo.Size = new Size(239, 27);
            txtTablo.TabIndex = 26;
            // 
            // rtxtQuery
            // 
            rtxtQuery.Location = new Point(402, 12);
            rtxtQuery.Name = "rtxtQuery";
            rtxtQuery.Size = new Size(460, 146);
            rtxtQuery.TabIndex = 27;
            rtxtQuery.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 180);
            Controls.Add(rtxtQuery);
            Controls.Add(txtTablo);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Log Tablo Create Script Oluşturma";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOlustur;
        private Label label4;
        private Label label3;
        private ComboBox cmbSema;
        private TextBox txtTablo;
        private RichTextBox rtxtQuery;
    }
}