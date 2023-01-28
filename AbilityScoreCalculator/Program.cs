using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreCalculator
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;
        
        public void CalculateAbilityScore()
        {
            // Dzielenie wyniku rzutu przez pole DivideBy
            double divided = RollResult / DivideBy;

            // Dodawanie AddAmount do wyniku dzielenia
            int added = AddAmount + (int)divided;

            // Jeśli wynik jest za niski, użyj Minimum
            if(added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
    internal class Program
    {
        /// <summary>
        /// Wyświetla informację i wczytuje wartości typu int z konsoli
        /// </summary>
        /// <param name="lastUsedValue">Wartość domyślna</param>
        /// <param name="prompt">Informacja wyświetlana w konsoli</param>
        /// <returns>Wczytana wartość int lub wartość domyślna (jeśli nie można przetworzyć wartości domyślnej)</returns>
        static int ReadInt(int lastUsedValue, string prompt)
        {
            // Wyświetlanie informacji i [wartości domyślnej]:
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            // Wczytywanie wiersza dancyh wyjściowych i używanie int.TryParse do próby ich przetworzenia. Jeśli to możliwe, wyświetlanie w konsoli
            string userAnswer = Console.ReadLine();
            // " użycie wartości " + value. W przeciwnym razie wysweitlanie w konsoli
            // " użycie wartośći domyślnej " + lastUsedValue.
            if (int.TryParse(userAnswer, out int userInt) && userInt != lastUsedValue)
            {
                Console.WriteLine("Użycie wartości: " + userInt);
                return userInt;
            }
            else
            {
                Console.WriteLine("Użycie wartości domyślnej: " + lastUsedValue);
                return lastUsedValue;
            }
        }

        /// <summary>
        /// Wyświetla informację i wczytuje wartości typu double z konsoli
        /// </summary>
        /// <param name="lastUsedValue">Wartość domyślna</param>
        /// <param name="prompt">Informacja wyświetlana w konsoli</param>
        /// <returns>Wczytana wartość double lub wartość domyślna (jeśli nie można przetworzyć wartości domyślnej)</returns>
        static double ReadDouble(double lastUsedValue, string prompt)
        {
            // Wyświetlanie informacji i [wartości domyślnej]:
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            // Wczytywanie wiersza dancyh wyjściowych i używanie double.TryParse do próby ich przetworzenia. Jeśli to możliwe, wyświetlanie w konsoli
            string userAnswer = Console.ReadLine();
            // " użycie wartości " + value. W przeciwnym razie wysweitlanie w konsoli
            // " użycie wartośći domyślnej " + lastUsedValue.
            if (double.TryParse(userAnswer, out double userInt) && userInt != lastUsedValue)
            {
                Console.WriteLine("Użycie wartości: " + userInt);
                return userInt;
            }
            else
            {
                Console.WriteLine("Użycie wartości domyślnej: " + lastUsedValue);
                return lastUsedValue;
            }
        }
        static void Main(string[] args)
        {
            float f1 = 185.26F;
            double d2 = 0.0000316D;
            decimal m3 = 37.26M;
            Console.WriteLine((int)f1 +" "+ (int)d2 +" "+ (int)m3);
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Początkowy rzut 4d6");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Dzielone przez");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Dodawana wartość");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Obliczone punkty umiejętności: " + calculator.Score);
                Console.WriteLine("Wciśnij Q, by zakończyć, lub inny klawisz, aby kontynuować");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }
    }
}
