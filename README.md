# NEATariffCalculator
A C# .Net Core practice application to calculate the tariff as per Nepal Electricity Authority tariff guidelines. This application calculates tariff for Single-phase, low-voltage (230V) 5-15Amp domestic consumers only.

The newly revised tariff as of 2077-03-01 are as follows.

|                |              5Amp             ||              15Amp            ||
|:--------------:|:--------------:|:-------------:|:--------------:|:-------------:|
| Units Consumed | Service Charge | Energy Charge | Service Charge | Energy Charge |
|     0 - 10     |       30       |      0.0      |       50       |      4.00     |
|     11 - 20    |       30       |      3.00     |       50       |      4.00     |
|     21 - 30    |       50       |      6.50     |       75       |      6.50     |
|     31 - 50    |       50       |      8.00     |       75       |      8.00     |
|    51 - 100    |       75       |      9.50     |       100      |      9.50     |
|    101 - 150   |       100      |      9.50     |       125      |      9.50     |
|    151 - 250   |       125      |     10.00     |       150      |     10.00     |
|    251 - 400   |       150      |     11.00     |       175      |     11.00     |
|      > 400     |       175      |     12.00     |       200      |     12.00     |
