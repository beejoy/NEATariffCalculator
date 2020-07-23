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
            AmpereEnum ampere = AmpereEnum.Ampere5;

            if (prevReading > currentReading)
            {
                int temp = currentReading;
                currentReading = prevReading;
                prevReading = temp;

                txtPrevReading.Text = prevReading.ToString();
                txtCurrentReading.Text = currentReading.ToString();
            }

            switch (cboTariff.SelectedIndex)
            {
                case 0:
                    ampere = AmpereEnum.Ampere5;
                    break;

                case 1:
                    ampere = AmpereEnum.Ampere15;
                    break;

                case 2:
                    ampere = AmpereEnum.Ampere30;
                    break;

                case 3:
                    ampere = AmpereEnum.Ampere60;
                    break;
            }

            Tariff myTariff = new Tariff(prevReading, currentReading, ampere);
            txtTariff.Text = $"{myTariff.CalculateTariff():C2}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboTariff.SelectedIndex = 0;
        }
    }
}
