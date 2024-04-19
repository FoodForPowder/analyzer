using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Анализатор_лексем
{
    public static class OR
    {
        private static void END()
        {
            Console.WriteLine("Распознан логический оператор : ||");
            InputData.Pointer++;
        }
        public static void Analyse()
        {
            InputData.Pointer++;
            switch (InputData.CurentCharGroup())
            {
                case "<ц>": throw new Exception("Недопустимый символ");
                case "<б>": throw new Exception("Недопустимый символ");
                case "< >": throw new Exception("Недопустимый символ");
                case "<\">": throw new Exception("Недопустимый символ");
                case "<,>": throw new Exception("Недопустимый символ");
                case "<;>": throw new Exception("Недопустимый символ");
                case "<с>": throw new Exception("Недопустимый символ");
                case "<<>": throw new Exception("Недопустимый символ");
                case "<>>": throw new Exception("Недопустимый символ");
                case "<=>": throw new Exception("Недопустимый символ");
                case "<&>": throw new Exception("Недопустимый символ");
                case "<|>": END(); break;
                case "<!>": throw new Exception("Недопустимый символ");
                case "<(>": throw new Exception("Недопустимый символ");
                case "<)>": throw new Exception("Недопустимый символ");
                case "<[>": throw new Exception("Недопустимый символ");
                case "<]>": throw new Exception("Недопустимый символ");
                case "<{>": throw new Exception("Недопустимый символ");
                case "<}>": throw new Exception("Недопустимый символ");
                case "<o>": throw new Exception("Недопустимый символ");
                default: throw new Exception("Недопустимый символ");
            }
        }
    }
}
