using System;

namespace AbilityScoreTester
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while (true)
            {
                calculator.rollResult = ReadInt(calculator.rollResult, "Starting 4d6 roll ");
                calculator.divideBy = ReadDouble(calculator.divideBy, "Divide by ");
                calculator.addAmount = ReadInt(calculator.addAmount, "Add amount ");
                calculator.minimum = ReadInt(calculator.minimum, "Minimum ");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
            
        }


        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + "[" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if(double.TryParse(line, out double value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine(" using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("   using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("   using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }



    }
}
