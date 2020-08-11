using System;
using System.Windows.Forms;
using NEATariff;

namespace NEATariffWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // make sure current reading is greater than previous reading

            int prevReading = Convert.ToInt32(txtPrevReading.Text);
            int currentReading = Convert.ToInt32(txtCurrentReading.Text);
            if (prevReading > currentReading)
            {
                int temp = currentReading;
                currentReading = prevReading;
                prevReading = temp;

                txtPrevReading.Text = prevReading.ToString();
                txtCurrentReading.Text = currentReading.ToString();
            }

            txtConsumedUnits.Text = (currentReading - prevReading).ToString();

            Tariff myTariff = new Tariff(prevReading, currentReading, (AmpereEnum)cboAmpere.SelectedIndex);
            txtTariff.Text = $"{myTariff.CalculateTariff():C2}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboAmpere.SelectedIndex = 0;
        }
    }
}
