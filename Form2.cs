using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_transferi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public void FillSchema(string schema)
        {
            cmbSema.Text = schema;
            cmbSema.Items.Add(schema);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void olustur_buton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTablo.Text))
            {
                MessageBox.Show("Lütfen tablo adı giriniz!", "Log Tablo Create Script Oluşturma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            StringBuilder sb = new($"CREATE TABLE {cmbSema.Text}.{txtTablo.Text} (");
            
            Form1.LogTableColumnsAsColumn.ForEach(x =>
            {
                sb.Append($"{x.COLUMN_NAME} {x.DATA_TYPE}{(x.CHARACTER_MAXIMUM_LENGTH.HasValue ? $"({x.CHARACTER_MAXIMUM_LENGTH.Value})" : "")} {(x.IS_NULLABLE.Equals("YES", StringComparison.InvariantCultureIgnoreCase) ? "null" : "not null")},");
            });
            
            rtxtQuery.Text = sb.ToString().TrimEnd(',') + ")";
        }

    }
}
