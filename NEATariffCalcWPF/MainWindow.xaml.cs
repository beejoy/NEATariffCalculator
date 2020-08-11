using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NEATariff;

namespace NEATariffCalcWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            TextBoxCurrentReading.Focus();
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            // make sure current reading is greater than previous reading

            int prevReading = Convert.ToInt32(TextBoxPreviousReading.Text);
            int currentReading = Convert.ToInt32(TextBoxCurrentReading.Text);

            if (prevReading > currentReading)
            {
                int temp = currentReading;
                currentReading = prevReading;
                prevReading = temp;

                TextBoxPreviousReading.Text = prevReading.ToString();
                TextBoxCurrentReading.Text = currentReading.ToString();
            }

            TextBoxConsumedUnits.Text = (currentReading - prevReading).ToString();

            Tariff myTariff = new Tariff(prevReading, currentReading, (AmpereEnum)ComboBoxAmpereDemand.SelectedIndex);
            TextBoxTotalTariff.Text = $"{myTariff.CalculateTariff():C2}";
        }
    }
}
