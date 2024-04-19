using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public static class Num
    {
        private static int number = 0;
        private static void END()
        {
            InputData.Pointer++;
            Console.WriteLine($"Распознано число: {number};");
            number = 0;
        }
        private static void END_minus()
        {
            Console.WriteLine($"Распознано число: {number};");
            number = 0;
        }
        public static void Analyse()
        {
            number = number * 10 + ((int)char.GetNumericValue(InputData.Current));
            InputData.Pointer++;
            switch (InputData.CurentCharGroup())
            {
                case "<цифра>": Analyse(); break;
                case "<буква>": throw new Exception("Недопустимый символ");
                case "< >": END(); break;
                case "<,>": END_minus(); break;
                case "<;>": END_minus(); break;
                case "<с>": END_minus(); break;
                case "<<>": END_minus(); break;
                case "<>>": END_minus(); break;
                case "<=>": END_minus(); break;
                case "<!>": END_minus(); break;
                case "<(>": throw new Exception("Недопустимый символ");
                case "<)>": END_minus(); break;
                case "<[>": throw new Exception("Недопустимый символ");
                case "<]>": END_minus(); break;
                case "<{>": throw new Exception("Недопустимый символ");
                case "<}>": throw new Exception("Недопустимый символ");
                default: throw new Exception("Недопустимый символ");
            }
        }
    }
}
