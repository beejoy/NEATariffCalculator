using System;
using NEATariff;

namespace NEATariffCalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tariff myTariff = new Tariff();

            do
            {
                Console.WriteLine("Nepal Electricity Authority : Tariff Calculator");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("");

                Console.Write("Enter Previous Reading: ");
                int prevReading = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Current Reading: ");
                int currentReading = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Total consumed energy units: {currentReading - prevReading}");

                Console.Write("Enter Energy Ampere (0 = 5 Ampere; 1 = 15 Ampere): ");
                int ampere = Convert.ToInt32(Console.ReadLine());

                myTariff.PreviousReading = prevReading;
                myTariff.CurrentReading = currentReading;
                if (ampere < 0 || ampere > 1)
                {
                    ampere = 0;
                }
                myTariff.Ampere = (AmpereEnum)ampere;

                Console.WriteLine($"Total Bill Amount: Rs. {myTariff.CalculateTariff():N2}");

                Console.WriteLine("============================================");
                Console.WriteLine("Press 'q' to quit, any other key to continue.");
                string keyInput = Console.ReadLine();

                if (keyInput.ToLower() == "q")
                {
                    break;
                }
                Console.Clear();
            } while (true);
            
        }
    }
}
