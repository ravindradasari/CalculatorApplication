using System;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            int intFirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            int intSecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            int IntResult = intFirstNumber + intSecondNumber;
            lblOutput.Text = IntResult.ToString();

        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            int intFirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            int intSecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            int IntResult = intFirstNumber - intSecondNumber;
            lblOutput.Text = IntResult.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int intFirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            int intSecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            int IntResult = intFirstNumber * intSecondNumber;
            lblOutput.Text = IntResult.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int intFirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            int intSecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            int IntResult = intFirstNumber / intSecondNumber;
            lblOutput.Text = IntResult.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
