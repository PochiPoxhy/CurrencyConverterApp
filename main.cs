using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Currency Converter!");

            // Exchange rates
            double usdToEurRate = 0.89;
            double usdToGbpRate = 0.78;
            double eurToUsdRate = 1.12;
            double eurToGbpRate = 0.87;
            double gbpToUsdRate = 1.29;
            double gbpToEurRate = 1.15;

            Console.Write("Enter the amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Available currencies: ");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. GBP");

            Console.Write("Enter the source currency (1-3): ");
            int sourceCurrency = int.Parse(Console.ReadLine());

            Console.Write("Enter the target currency (1-3): ");
            int targetCurrency = int.Parse(Console.ReadLine());

            double convertedAmount = 0;

            // Conversion calculations
            if (sourceCurrency == 1)
            {
                if (targetCurrency == 2)
                {
                    convertedAmount = amount * usdToEurRate;
                }
                else if (targetCurrency == 3)
                {
                    convertedAmount = amount * usdToGbpRate;
                }
                else
                {
                    convertedAmount = amount;
                }
            }
            else if (sourceCurrency == 2)
            {
                if (targetCurrency == 1)
                {
                    convertedAmount = amount * eurToUsdRate;
                }
                else if (targetCurrency == 3)
                {
                    convertedAmount = amount * eurToGbpRate;
                }
                else
                {
                    convertedAmount = amount;
                }
            }
            else if (sourceCurrency == 3)
            {
                if (targetCurrency == 1)
                {
                    convertedAmount = amount * gbpToUsdRate;
                }
                else if (targetCurrency == 2)
                {
                    convertedAmount = amount * gbpToEurRate;
                }
                else
                {
                    convertedAmount = amount;
                }
            }
            else
            {
                convertedAmount = amount;
            }

            Console.WriteLine("Converted amount: " + convertedAmount);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

