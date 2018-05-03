using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timesup = 0;


        private void tpCalculator_Click(object sender, EventArgs e)
        {

        }
        public double calcPayment(double presentValue, double financingPeriod, double interestRatePerYear)
        {
            double a, b, x;
            double monthlyPayment;
            a = (1 + interestRatePerYear / 1200);
            b = financingPeriod * 12;
            x = Math.Pow(a, b);
            x = 1 / x;
            x = 1 - x;
            monthlyPayment = (presentValue) * (interestRatePerYear / 1200) / x;
            return (monthlyPayment);
        }

        private void SomeEvent(object sender, EventArgs e)
        {
            double payment = calcPayment(50000, 30, 8.5);
            MessageBox.Show(payment.ToString());
        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            //Declare and initialize all variables.
            double loanAmount = 0.0;
            double fixedInterestRate = 0.0;
            int years = 0;

            double monthlyPayment = 0.0;
            int numberOfPayments = 0;
            double paymentTotal = 0.0;
            double interestPaid = 0.0;

            //Convert user input fields to numeric format.
            loanAmount = Convert.ToDouble(txtLoanAmount.Text);
            fixedInterestRate = Convert.ToDouble(txtFixedInterestRate.Text);
            years = Convert.ToInt16(cmbYears.Text);
            //Perform all calculations
            monthlyPayment = calcPayment(loanAmount, years, fixedInterestRate);
            numberOfPayments = years * 12;
            paymentTotal = numberOfPayments * monthlyPayment;
            interestPaid = paymentTotal - loanAmount;
            //Place the calculations on the screen 
            txtMonthlyPayments.Text = string.Format("{0:c}", monthlyPayment);
            txtNumberOfPayments.Text = Convert.ToString(numberOfPayments);
            txtInterestPaid.Text = String.Format("{0:c}", interestPaid);
            txtPaymentTotal.Text = string.Format("{0:c}", paymentTotal);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLoanAmount.Select();
            cmbYears.SelectedIndex = 5;
            gbColor.BackColor = Color.Red;
            lblDate.Text = System.DateTime.Now.ToLongDateString();
            lblTime.Text = System.DateTime.Now.ToLongTimeString();
            { webBrowser1.Navigate("http://www.google.com"); }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
                gbColor.BackColor = Color.Red;
            if (rbGreen.Checked)
                gbColor.BackColor = Color.Green;
            if (rbYellow.Checked)
                gbColor.BackColor = Color.Yellow;
            if (rbBlue.Checked)
                gbColor.BackColor = Color.Blue;

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            timesup++;
            {
                if (timesup == 10)
                {
                    MessageBox.Show("It's OVER");
                    Application.Exit();
                }



            }
            lblTime.Text = System.DateTime.Now.ToLongTimeString();
            lblDate.Text = System.DateTime.Now.ToLongDateString();


            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
        }

        private void txtLoanAmount_Validating(object sender, CancelEventArgs e)

        {
            try
            {
                double loanAmount = 0.0;

                loanAmount = Convert.ToDouble(txtLoanAmount.Text);
            }
            catch
            {
                errorProvider1.SetError(txtLoanAmount, "Invalid Value");
                txtLoanAmount.Select();
            }
        }

        private void txtFixedInterestRate_Validated(object sender, EventArgs e)
        {

            try
            {
                double interestRate = 0.0;

                interestRate = Convert.ToDouble(txtFixedInterestRate.Text);
            }
            catch
            {
                errorProvider1.SetError(txtFixedInterestRate, "Invalid Value");
                txtFixedInterestRate.Select();
            }

        }
        private void tsbBack_Click(object sender, EventArgs e)
        { webBrowser1.GoBack(); }
        private void tsbSearch_Click(object sender, EventArgs e)
        { webBrowser1.GoSearch(); }
        private void tsbHome_Click(object sender, EventArgs e)
        { webBrowser1.GoHome(); }
        private void tsbRefresh_Click(object sender, EventArgs e)
        { webBrowser1.Refresh(); }
        private void tsbForward_Click(object sender, EventArgs e)
        { webBrowser1.GoForward(); }
        private void tsbStop_Click(object sender, EventArgs e)
        { webBrowser1.Stop(); }

        private void tsbGoLocation_Click(object sender, EventArgs e)
        { webBrowser1.Navigate(tstxtLocation.Text); }
        private void tstxtLocation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                webBrowser1.Navigate(tstxtLocation.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        { tstxtLocation.Text = webBrowser1.Url.ToString(); }

        private void tpDialog_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pnlColor.BackColor = colorDialog1.Color;
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lblFont.Font = fontDialog1.Font;

        }

        private void btnChooseImageFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Invalid Image File!!");
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void stretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpBrowser;
            webBrowser1.Navigate(comboBox1.Text);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            MessageBox.Show("You chose a " + dateTimePicker1.Value.DayOfWeek);

        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {

            MessageBox.Show("WOW!");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            {
                MessageBox.Show("You chose a " + monthCalendar1.SelectionStart.DayOfWeek);
            }
        }

        private void btnFontChanger_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CLICKITY CLACK CLACK");

        }
    }
}



