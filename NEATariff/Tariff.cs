using System;
using System.Collections.Generic;

namespace NEATariff
{
    public enum AmpereEnum
    {
        Ampere5,
        Ampere15,
        Ampere30,
        Ampere60
    }

    public class Tariff
    {
        // service charge (update as per NEA rates)
        private double[,] serviceCharge = new double[,]
        {
            { 30, 50, 75, 125 },
            { 30, 50, 75, 125 },
            { 50, 75, 100, 125 },
            { 50, 75, 100, 125 },
            { 75, 100, 125, 150 },
            { 100, 125, 150, 200 },
            { 125, 150, 175, 200 },
            { 150, 175, 200, 250 },
            { 175, 200, 225, 275 }
        };

        // energy charge (update as per NEA rates)
        private double[,] energyCharge = new double[,]
        {
            { 0.0, 4.0, 5.0, 6.0 },
            { 3.0, 4.0, 5.0, 6.0 },
            { 6.5, 6.5, 6.5, 6.5 },
            { 8.0, 8.0, 8.0, 8.0 },
            { 9.5, 9.5, 9.5, 9.5 },
            { 9.5, 9.5, 9.5, 9.5 },
            { 10.0, 10.0, 10.0, 10.0 },
            { 11.0, 11.0, 11.0, 11.0 },
            { 12.0, 12.0, 12.0, 12.0 }
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
                if (consumedUnits > 10)
                {
                    unitSlots.Add(10);
                }
                else
                {
                    unitSlots.Add(consumedUnits);
                }

                // consumed unti slot 2
                if (consumedUnits > 20)
                {
                    unitSlots.Add(10);
                }
                else if (consumedUnits > 10)
                {
                    unitSlots.Add(consumedUnits - 10);
                }

                // consumed unit slot 3
                if (consumedUnits > 30)
                {
                    unitSlots.Add(10);
                }
                else if (consumedUnits > 20)
                {
                    unitSlots.Add(consumedUnits - 20);
                }

                // consumed unit slot 4
                if (consumedUnits > 50)
                {
                    unitSlots.Add(20);
                }
                else if (consumedUnits > 30)
                {
                    unitSlots.Add(consumedUnits - 30);
                }

                // consumed unit slot 5
                if (consumedUnits > 100)
                {
                    unitSlots.Add(50);
                }
                else if (consumedUnits > 50)
                {
                    unitSlots.Add(consumedUnits - 50);
                }

                // consumed unit slot 6
                if (consumedUnits > 150)
                {
                    unitSlots.Add(50);
                }
                else if (consumedUnits > 100)
                {
                    unitSlots.Add(consumedUnits - 100);
                }

                // consumed unit slot 7
                if (consumedUnits > 250)
                {
                    unitSlots.Add(100);
                }
                else if (consumedUnits > 150)
                {
                    unitSlots.Add(consumedUnits - 150);
                }

                // consumed unit slot 8
                if (consumedUnits > 400)
                {
                    unitSlots.Add(150);
                }
                else if (consumedUnits > 250)
                {
                    unitSlots.Add(consumedUnits - 250);
                }

                // consumed unit slot 9
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
