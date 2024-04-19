using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public static class NotEqual
    {
        private static void END()
        {
             Console.WriteLine("Распознан оператор неравенства: !");
            
            InputData.Pointer++;
        }
        private static void END_minus()
        {
            Console.WriteLine("Распознан оператор неравенства: !");
        }

        public static void Analyse()
        {
            InputData.Pointer++;
            switch (InputData.CurentCharGroup())
            {
                case "<цифра>": END_minus(); break;
                case "<буква>": END_minus(); break;
                case "< >": END(); break;
                case "<,>": throw new Exception("Недопустимый символ");
                case "<;>": throw new Exception("Недопустимый символ");
                case "<с>": END_minus(); break;
                case "<<>": throw new Exception("Недопустимый символ");
                case "<>>": throw new Exception("Недопустимый символ");
                case "<=>": throw new Exception("Недопустимый символ");
                case "<!>": END(); break;
                case "<(>": END_minus(); break;
                case "<)>": throw new Exception("Недопустимый символ");
                case "<[>": throw new Exception("Недопустимый символ");
                case "<]>": throw new Exception("Недопустимый символ");
                case "<{>": throw new Exception("Недопустимый символ");
                case "<}>": throw new Exception("Недопустимый символ");
                case "<O>": throw new Exception("Недопустимый символ");
                default: throw new Exception("Недопустимый символ");
            }
        }
    }
}
