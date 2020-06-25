using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (rad15A.Checked)
            {
                ampere = AmpereEnum.Ampere15;
            }
            
            Tariff myTariff = new Tariff(prevReading, currentReading, ampere);
            txtTariff.Text = myTariff.CalculateTariff().ToString();
        }
    }
}
