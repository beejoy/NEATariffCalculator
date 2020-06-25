using System;
using System.Collections.Generic;

namespace NEATariff
{
    public enum AmpereEnum
    {
        Ampere5,
        Ampere15
    }

    public class Tariff
    {
        // tariff for 5 Ampere consumers
        private double[,] tariff5amp = new double[,] { { 30.0, 3.0 }, { 50.0, 7.0 }, { 75.0, 8.5 }, { 100.0, 10.0 }, { 125.0, 11.0 }, { 150.0, 12.0 }, { 175.0, 13.0 } };

        // tariff for 15 Ampere consumers
        private double[,] tariff15amp = new double[,] { { 50.0, 4.0 }, { 75.0, 7.0 }, { 100.0, 8.5 }, { 125.0, 10.0 }, { 150.0, 11.0 }, { 175.0, 12.0 }, { 200.0, 13.0 } };

        // service charge
        private double[,] serviceCharge = new double[,]
        {
            { 30, 50 },
            { 50, 75 },
            { 75, 100 },
            { 100, 125 },
            { 125, 150 },
            { 150, 175 },
            { 175, 200 }
        };

        // energy charge
        private double[,] energyCharge = new double[,]
        {
            { 3.0, 4.0 },
            { 7.0, 7.0 },
            { 8.5, 8.5 },
            { 10.0, 10.0 },
            { 11.0, 11.0 },
            { 12.0, 12.0 },
            { 13.0, 13.0 }
        };

        public int PreviousReading { get; set; }
        public int CurrentReading { get; set; }
        
        private AmpereEnum ampere;
        public AmpereEnum Ampere
        {
            private get
            {
                return ampere;
            }
            set
            {
                ampere = value;
            }
        }

        public Tariff()
        {
            PreviousReading = 0;
            CurrentReading = 0;
            Ampere = AmpereEnum.Ampere5;
        }

        public Tariff(int previousReading, int currentReading, AmpereEnum ampere)
        {
            PreviousReading = previousReading;
            CurrentReading = currentReading;
            Ampere = ampere;
        }

        public double CalculateTariff()
        {
            double tariff = 0.0;
            int consumedUnits = CurrentReading - PreviousReading;
            List<int> unitSlots = new List<int>();

            // calculate total tariff based on consumed units
            if (consumedUnits > 0)
            {
                // consumed unit slot 1
                if (consumedUnits > 20)
                {
                    unitSlots.Add(20);
                }
                else
                {
                    unitSlots.Add(consumedUnits);
                }

                // consumed unit slot 2
                if (consumedUnits > 30)
                {
                    unitSlots.Add(10);
                }
                else if (consumedUnits > 20)
                {
                    unitSlots.Add(consumedUnits - 20);
                }

                // consumed unit slot 3
                if (consumedUnits > 50)
                {
                    unitSlots.Add(20);
                }
                else if (consumedUnits > 30)
                {
                    unitSlots.Add(consumedUnits - 30);
                }

                // consumed unit slot 4
                if (consumedUnits > 150)
                {
                    unitSlots.Add(100);
                }
                else if (consumedUnits > 50)
                {
                    unitSlots.Add(consumedUnits - 50);
                }

                // consumed unit slot 5
                if (consumedUnits > 250)
                {
                    unitSlots.Add(100);
                }
                else if (consumedUnits > 150)
                {
                    unitSlots.Add(consumedUnits - 150);
                }

                // consumed unit slot 6
                if (consumedUnits > 400)
                {
                    unitSlots.Add(150);
                }
                else if (consumedUnits > 250)
                {
                    unitSlots.Add(consumedUnits - 250);
                }

                // consumed unit slot 7
                if (consumedUnits > 400)
                {
                    unitSlots.Add(consumedUnits - 400);
                }
            }

            for(int i = 0; i < unitSlots.Count; i++)
            {
                tariff += unitSlots[i] * energyCharge[i, (int)Ampere];
            }
            
            tariff += serviceCharge[unitSlots.Count-1, (int)Ampere];

            return tariff;
        }
    }
}
