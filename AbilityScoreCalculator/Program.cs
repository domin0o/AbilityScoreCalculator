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
