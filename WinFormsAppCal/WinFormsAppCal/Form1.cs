namespace WinFormsAppCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.ReadOnly = true;
            radioPlus.Checked = true;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtX.Text, out double numX) || !double.TryParse(txtY.Text, out double numY))
            {
                MessageBox.Show("�п�J���T���Ʀr");
                return;
            }

            ICalculatorOperation? operation = null;

            try
            {
                if (radioPlus.Checked)
                    operation = new AddOperation();
                else if (radioMinus.Checked)
                    operation = new SubtractOperation();
                else if (radioTimes.Checked)
                    operation = new MultiplyOperation();
                else if (radioDiv.Checked)
                    operation = new DivideOperation();

                if (operation == null)
                {
                    MessageBox.Show("�п�ܤ@�عB��覡�I");
                    return;
                }

                CalculatorDelegate calcDelegate = operation.Calculate;
                double result = calcDelegate(numX, numY);

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
