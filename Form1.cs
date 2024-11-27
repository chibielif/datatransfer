using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Dapper;
using Serilog;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace veri_transferi
{
    public partial class Form1 : Form
    {
        private static string _connectionStringFormat = "Data Source={0};Initial Catalog={1};User ID=sa;Password=Test1234.;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static SqlConnection GetConnection(string source, string catalog) => new(string.Format(_connectionStringFormat, source, catalog));

        private List<string> result;
        private string source;
        private string catalog;
        private string schema;
        private string schema2;
        private string table;
        private string table2;
        private string wccIcerikId;
        private string wccIcerikRevId;
        private bool _isTransferStoppedOnError;


        public Form1()
        {
            InitializeComponent();


            InitializeBackgroundWorker();


            //default hata log klasoru olarak uygulamanın calistigi klasoru yaziyoruz
            txtHataLogKlasoru.Text = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);

            //baslat butonu calismadan durdur calisamaz
            btnDurdur.Enabled = false;

            txtServisAdresi.Text = "http://127.0.0.1:9000";
            txtAccessKey.Text = "IKhhhvV3U4ELqaX7zqKU";
            txtSecretAccessKey.Text = "00CYlEU4Orx9vXBhUHsEQndL3vaBlbS3dL8vfEjD";
            txtBucketAdi.Text = "mybucket";
        }

        private void InitializeBackgroundWorker()

        {

            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.WorkerReportsProgress = true;

            progressBar.Minimum = 1;

            progressBar.Step = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kaynak_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKatalog.Items.Clear();
            cmbSema.Items.Clear();
            cmbSema2.Items.Clear();
            cmbTablo.Items.Clear();
            cmbTablo2.Items.Clear();
            cmbIcerikId.Items.Clear();
            cmbIcerikRevId.Items.Clear();
            cmbPrimaryKey.Items.Clear();

            try
            {
                source = cmbKaynak.Text;
                SqlConnection connection = GetConnection(source, "master"); // source = localhost olacak, "master" database in adi
                connection.Open();
                result = connection.Query<string>("SELECT NAME FROM SYS.DATABASES ORDER BY 1 ASC").ToList();
                connection.Close();
                cmbKatalog.Items.Clear();
                cmbKatalog.Items.AddRange(result.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Baglanirken hata olustu: {ex.Message}");
                //Log.Error(ex.Message, ex);
            }

        }

        private void katalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSema.Items.Clear();
            cmbSema2.Items.Clear();
            cmbTablo.Items.Clear();
            cmbTablo2.Items.Clear();
            cmbIcerikId.Items.Clear();
            cmbIcerikRevId.Items.Clear();
            cmbPrimaryKey.Items.Clear();
            try
            {
                catalog = cmbKatalog.Text;
                SqlConnection connection = GetConnection(source, catalog);
                connection.Open();
                result = connection.Query<string>($"SELECT DISTINCT TABLE_SCHEMA FROM {catalog}.INFORMATION_SCHEMA.TABLES").ToList();
                connection.Close();

                cmbSema.Items.Clear();
                cmbSema2.Items.Clear();

                cmbSema.Items.AddRange(result.ToArray());
                cmbSema2.Items.AddRange(result.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Katalog seciminde hata olustu: {ex.Message}");
                //Log.Error(ex.Message, ex);
            }


        }

        private void sema_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTablo.Items.Clear();
            cmbTablo2.Items.Clear();
            cmbIcerikId.Items.Clear();
            cmbIcerikRevId.Items.Clear();
            cmbPrimaryKey.Items.Clear();
            try
            {
                schema = cmbSema.Text;
                SqlConnection connection = GetConnection(source, catalog);
                connection.Open();
                result = connection.Query<string>($"SELECT DISTINCT TABLE_NAME FROM {catalog}.INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{schema}'").ToList();
                connection.Close();

                cmbTablo.Items.Clear();
                cmbTablo2.Items.Clear();

                cmbTablo.Items.AddRange(result.ToArray());
                cmbTablo2.Items.AddRange(result.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sema seciminde hata olustu: {ex.Message}");
                //Log.Error(ex.Message, ex);
            }
        }

        private void tablo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIcerikId.Items.Clear();
            cmbIcerikRevId.Items.Clear();
            cmbPrimaryKey.Items.Clear();
            try
            {
                table = cmbTablo.Text;
                SqlConnection connection = GetConnection(source, catalog);
                connection.Open();
                result = connection.Query<string>($"SELECT DISTINCT COLUMN_NAME FROM {catalog}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{schema}' AND TABLE_NAME = '{table}'").ToList();
                connection.Close();

                cmbIcerikId.Items.Clear();
                cmbIcerikRevId.Items.Clear();
                cmbPrimaryKey.Items.Clear();

                cmbIcerikId.Items.AddRange(result.ToArray());
                cmbIcerikRevId.Items.AddRange(result.ToArray());
                cmbPrimaryKey.Items.AddRange(result.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tablo seciminde hata olustu: {ex.Message}");
                //Log.Error(ex.Message, ex);
            }
        }

        private void icerikId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void icerikRevId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hata_log_sec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = "C:\\";

            //dialog acilir
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog.SelectedPath;
                txtHataLogKlasoru.Clear();
                txtHataLogKlasoru.Text = folderName;
            }
        }

        private void klasor_sec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = "C:\\Users\\elfkl\\Desktop\\";

            //dialog acilir
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog.SelectedPath;
                txtKlasor.Clear();
                txtKlasor.Text = folderName;
            }
        }

        private void sema2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                schema2 = cmbSema2.Text;
                SqlConnection connection = GetConnection(source, catalog);
                connection.Open();
                result = connection.Query<string>($"SELECT DISTINCT TABLE_NAME FROM {catalog}.INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{schema2}'").ToList();
                connection.Close();

                cmbTablo2.Items.Clear();
                cmbTablo2.Items.AddRange(result.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sema seciminde hata olustu: {ex.Message}");
                //Log.Error(ex.Message, ex);
            }
        }

        private void tablo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            table2 = cmbTablo2.Text;
        }

        private void create_script_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FillSchema(schema2);
            form2.ShowDialog();
        }

        public static List<Column> LogTableColumnsAsColumn => [

        new Column() { COLUMN_NAME = "Id", IS_NULLABLE = "NO", DATA_TYPE = "uniqueidentifier" },

        new Column() { COLUMN_NAME = "SemaAdi", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "TabloAdi", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "PrimaryKeySutunAdi", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "WccIcerikIdSutunAdi", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "WccIcerikRevIdSutunAdi", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "PrimaryKey", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "WccIcerikId", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "WccIcerikRevId", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "S3IcerikId", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "S3IcerikRevId", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 50 },

        new Column() { COLUMN_NAME = "IcerikSHA1Hash", IS_NULLABLE = "NO", DATA_TYPE = "varchar", CHARACTER_MAXIMUM_LENGTH = 100 },

        new Column() { COLUMN_NAME = "TransferTarihi", IS_NULLABLE = "NO", DATA_TYPE = "datetime" }

        ];

        public static bool IsLogTableColumn(Column column) => LogTableColumnsAsColumn.Any(c => c.DATA_TYPE.Equals(column.DATA_TYPE, StringComparison.InvariantCultureIgnoreCase) &&

                                   c.CHARACTER_MAXIMUM_LENGTH.Equals(column.CHARACTER_MAXIMUM_LENGTH) &&

                                   c.COLUMN_NAME.Equals(column.COLUMN_NAME, StringComparison.InvariantCultureIgnoreCase) &&

                                   c.IS_NULLABLE.Equals(column.IS_NULLABLE, StringComparison.InvariantCultureIgnoreCase));

        private void kontrol_et_button_Click(object sender, EventArgs e)
        {
            GetColumnsAsColumn(source, catalog, schema2, table2).ForEach(x =>
            {
                if (!IsLogTableColumn(x))
                {
                    MessageBox.Show($"{x.COLUMN_NAME} sütun bilgisi uygun değildir. Lütfen tablonuzu 'Create Script' ile oluşturunuz!", "Kontrol Et", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            });
        }

        public static List<Column> GetColumnsAsColumn(string source, string catalog, string schema, string table)
        {
            List<Column> result = [];
            try
            {
                SqlConnection conn = GetConnection(source, catalog);
                conn.Open();
                result = conn.Query<Column>(string.Format("SELECT DISTINCT COLUMN_NAME, IS_NULLABLE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{0}' AND TABLE_NAME = '{1}' ORDER BY 1 ASC", schema, table)).ToList();
                conn.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }

            return result;
        }

        private void baslat_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtServisAdresi.Text) || String.IsNullOrEmpty(txtAccessKey.Text) || String.IsNullOrEmpty(txtSecretAccessKey.Text) || String.IsNullOrEmpty(txtBucketAdi.Text)
                || String.IsNullOrEmpty(txtKlasor.Text))
            {
                MessageBox.Show("Servis adresi, access key, secret access key, bucket adi, klasor adi bos olamaz! Kontrol ettikten sonra tekrar deneyin.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form dialogBox = new Form();
                DialogResult result = MessageBox.Show("Veri transferini baslatmak istediginize emin misiniz?", "Islemi Onayla",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox5.Enabled = false;

                    btnBaslat.Enabled = false;
                    btnDurdur.Enabled = true;
                }
            }

            Log.Logger = new LoggerConfiguration().WriteTo.RichTextBox(richTextBox, Serilog.Events.LogEventLevel.Verbose).CreateLogger();
            var fileNames = new List<string>();
            try
            {
                SqlConnection connection = GetConnection(source, catalog);
                connection.Open();
                fileNames = connection.Query<string>($"SELECT CONCAT({cmbIcerikId.Text}, '_',{cmbIcerikRevId.Text}) from {schema}.{table};").ToList();
                connection.Close();
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }

            progressBar.ResetText();

            progressBar.Value = 1;

            progressBar.Maximum = fileNames?.Count ?? 1;

            _isTransferStoppedOnError = cmbCalismaSekli.SelectedIndex == 0;
           
            Log.Information("Veri transferi başlatıldı.");

            //backgroundworker call
            backgroundWorker1.RunWorkerAsync(fileNames);
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;

            btnBaslat.Enabled = true;
            btnDurdur.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var fileNames = (List<string>)e.Argument;

            IAmazonS3 client = new AmazonS3Client(txtAccessKey.Text, txtSecretAccessKey.Text,
                new AmazonS3Config
                {
                    ServiceURL = txtServisAdresi.Text,
                    UseHttp = false
                });

            string path = txtKlasor.Text;

            if (fileNames?.Count > 0)
            {
                while (!backgroundWorker1.CancellationPending && fileNames.Count > 0)
                {
                    try
                    {
                        var fileName = fileNames.First() + ".txt";

                        string filePath = Path.Combine(path, fileName);
                        if (File.Exists(filePath))
                        {
                            var result = client.PutObjectAsync(new Amazon.S3.Model.PutObjectRequest
                            {
                                BucketName = txtBucketAdi.Text,
                                Key = $"{fileName}",
                                InputStream = new MemoryStream(File.ReadAllBytes(filePath))
                            }).Result;
                            Log.Warning("One file uploaded.");

                            //delete the file after upload
                            File.Delete(filePath);
                        }
                        else
                        {
                            Log.Error("No file found with this filename.");
                        }
                        
                        fileNames.RemoveAt(0);
                        Thread.Sleep(2000);
                    }

                    catch (Exception ex)
                    {
                        Log.Error(ex.Message, ex);
                        if (_isTransferStoppedOnError)
                            throw;
                    }
                    
                    backgroundWorker1.ReportProgress(1);
                }
            }

            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                e.Result = true;
            }
        }
        


        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Increment(e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;

            btnBaslat.Enabled = true;
            btnDurdur.Enabled = false;
            Log.Information("Veri transferi tamamlandı.");
        }

        private void cmbCalismaSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}



