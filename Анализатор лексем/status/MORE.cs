using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Анализатор_лексем
{
    public static class MORE
    {
        private static void END()
        {
            if (InputData.Current == ' ') Console.WriteLine("Распознан оператор присваивания: > ");
            else if (InputData.Current == '=') Console.WriteLine("Распознан оператор сравнения: >= ");
            else throw new Exception("Недопустимый символ");
            InputData.Pointer++;
        }
        private static void END_minus()
        {
            Console.WriteLine("Распознан оператор сравнения: > ");
        }

        public static void Analyse()
        {
            InputData.Pointer++;
            switch (InputData.CurentCharGroup())
            {
                case "<ц>": END_minus(); break;
                case "<б>": END_minus(); break;
                case "< >": END(); break;
                case "<\">": END_minus(); break;
                case "<,>": throw new Exception("Недопустимый символ");
                case "<;>": throw new Exception("Недопустимый символ");
                case "<с>": END_minus(); break;
                case "<<>": throw new Exception("Недопустимый символ");
                case "<>>": throw new Exception("Недопустимый символ");
                case "<=>": END(); break;
                case "<&>": throw new Exception("Недопустимый символ");
                case "<|>": throw new Exception("Недопустимый символ");
                case "<!>": throw new Exception("Недопустимый символ");
                case "<(>": END_minus(); break;
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
