using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public static class Id 
    {
        private static readonly List<string> _reservedWords = new List<string>() { "integer", "mass", "if", "then", "else", "while", "do", "read", "write" };
        private static string _word = "";
        private static void END()
        {
            InputData.Pointer++;
            END_minus();
        }
        private static void END_minus()
        {
            if (_reservedWords.Contains(_word))
                Console.WriteLine($"Распознано зарезервированное слово: {_word};");
            else
                Console.WriteLine($"Распознан идентификатор: {_word};");
            _word = "";
        }

        public static void Analyse()
        {
            _word += InputData.Current;
            InputData.Pointer++;
            switch (InputData.CurentCharGroup())
            {
                case "<цифра>": Analyse(); break;
                case "<буква>": Analyse(); break;
                case "< >": END(); break;
                case "<,>": END_minus(); break;
                case "<;>": END_minus(); break;
                case "<с>": END_minus(); break;
                case "<<>": END_minus(); break;
                case "<>>": END_minus(); break;               
                case "<=>": END_minus(); break;               
                case "<!>": END_minus(); break;
                case "<#>": END_minus(); break;
                case "<(>": END_minus(); break;
                case "<)>": END_minus(); break;
                case "<[>": END_minus(); break;
                case "<]>": END_minus(); break;
                case "<{>": END_minus(); break;
                case "<}>": throw new Exception("Недопустимый символ");
                case "<O>": throw new Exception("Недопустимый символ");
                default: throw new Exception("Недопустимый символ");
            }
        }
    }
}
