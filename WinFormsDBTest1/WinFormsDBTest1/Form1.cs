using Microsoft.Data.SqlClient;

namespace WinFormsDBTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection();
        void ShowConnection()
        {
            rtbShow.Text = $"連接字串 : {cn.ConnectionString}\n";
            rtbShow.Text += $"逾時秒數 : {cn.ConnectionTimeout}\n";
            rtbShow.Text += $"資料庫 : {cn.Database}\n";
            rtbShow.Text += $"資料來源 : {cn.DataSource}\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                  "AttachDbFilename=|DataDirectory|\\TestDB1.mdf;" +
                                  "Integrated Security=True";
            // 路徑 : C:\Github\WinformPractice\WinFormsDBTest1\WinFormsDBTest1\bin\Debug\net8.0-windows\TestDB1.mdf

            //cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            //                      @"AttachDbFilename=C:\Github\WinformPractice\WinFormsDBTest1\WinFormsDBTest1\TestDB1.mdf;" +
            //                       "Integrated Security=True";
            ShowConnection();
        }

        private void btnCnState_Click(object sender, EventArgs e)
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
                btnCnState.Text = "關閉";
                rtbShow.Text += "目前狀態 : 資料庫已連接\n";
            }
            else if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
                btnCnState.Text = "連線";
                rtbShow.Text += "目前狀態 : 資料庫已關閉\n";
            }
            ShowConnection();
        }
    }
}
