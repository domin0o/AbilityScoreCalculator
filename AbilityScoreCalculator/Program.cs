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
            int added = AddAmount += (int)divided;

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

        ///<summary>
        /// Wyświetla informację i wczytuje wartość typu int z konsoli
        ///</summary>
        ///
        static int ReadInt(int lastUsedValue, string prompt)
        {
            // Wyświetlanie informacji i [wartości domyślnej]:
            // Wczytywanie wiersza dancyh wyjściowych i używanie int.TryParse do próby ich przetworzenia. Jeśli to możliwe, wyświetlanie w konsoli
            // " użycie wartości " + value. W przeciwnym razie wysweitlanie w konsoli
            // " użycie wartośći domyślnej " + lastUsedValue.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

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
