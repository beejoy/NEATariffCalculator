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

                try
                {
                    int prevReading = 0;
                    Console.Write("Enter Previous Reading: ");
                    prevReading = Convert.ToInt32(Console.ReadLine());

                    int currentReading = 0;
                    Console.Write("Enter Current Reading: ");
                    currentReading = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Total consumed energy units: {currentReading - prevReading}");

                    Console.Write("Enter Energy Ampere ([0] = 5A; 1 = 15A; 2 = 30A; 3 = 60A): ");
                    int ampere;
                    try
                    {
                        ampere = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        // Default Ampere is 5A
                        ampere = 0;
                    }

                    myTariff.PreviousReading = prevReading;
                    myTariff.CurrentReading = currentReading;
                    if (ampere < 0 || ampere > 3)
                    {
                        ampere = 0;
                    }
                    myTariff.Ampere = (AmpereEnum)ampere;

                    try
                    {
                        Console.WriteLine($"Total Bill Amount: Rs. {myTariff.CalculateTariff():N2}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, enter correct numerical values for calculation.");
                }

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
