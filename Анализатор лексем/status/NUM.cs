using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Анализатор_лексем
{
    public static class NUM
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
            number = number * 10 + (InputData.Current - '0');
            InputData.Pointer++;
            switch (InputData.CurentCharGroup())
            {
                case "<ц>":  Analyse(); break;
                case "<б>":  throw new Exception("Недопустимый символ");
                case "< >":  END(); break;
                case "<\">": throw new Exception("Недопустимый символ");
                case "<,>":  END_minus(); break;
                case "<;>":  END_minus(); break;
                case "<с>":  END_minus(); break;
                case "<<>":  END_minus(); break;
                case "<>>":  END_minus(); break;
                case "<=>":  END_minus(); break;
                case "<&>":  END_minus(); break;
                case "<|>":  END_minus(); break;
                case "<!>":  throw new Exception("Недопустимый символ");
                case "<(>":  throw new Exception("Недопустимый символ");
                case "<)>":  END_minus(); break;
                case "<[>":  throw new Exception("Недопустимый символ");
                case "<]>":  END_minus(); break;
                case "<{>":  throw new Exception("Недопустимый символ");
                case "<}>":  throw new Exception("Недопустимый символ");
                case "<o>":  throw new Exception("Недопустимый символ");
                default:     throw new Exception("Недопустимый символ");
            }
        }
    }
}
