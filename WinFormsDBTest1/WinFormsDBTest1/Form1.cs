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
            rtbShow.Text = $"�s���r�� : {cn.ConnectionString}\n";
            rtbShow.Text += $"�O�ɬ�� : {cn.ConnectionTimeout}\n";
            rtbShow.Text += $"��Ʈw : {cn.Database}\n";
            rtbShow.Text += $"��ƨӷ� : {cn.DataSource}\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                  "AttachDbFilename=|DataDirectory|\\TestDB1.mdf;" +
                                  "Integrated Security=True";
            // ���| : C:\Github\WinformPractice\WinFormsDBTest1\WinFormsDBTest1\bin\Debug\net8.0-windows\TestDB1.mdf

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
                btnCnState.Text = "����";
                rtbShow.Text += "�ثe���A : ��Ʈw�w�s��\n";
            }
            else if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
                btnCnState.Text = "�s�u";
                rtbShow.Text += "�ثe���A : ��Ʈw�w����\n";
            }
            ShowConnection();
        }
    }
}
