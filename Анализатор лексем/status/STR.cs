using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Анализатор_лексем
{
    public static class STR
    {
        private static string _string = "";
        private static void END()
        {
            InputData.Pointer++;
            Console.WriteLine($"Распознан строковый литерал: {_string};");
            _string = "";
        }

        public static void Analyse()
        {
            _string += InputData.Current;
            InputData.Pointer++;
            switch (InputData.CurentCharGroup())
            {
                case "<ц>": 
                case "<б>": 
                case "< >": Analyse(); break;
                case "<\">": END(); break;
                case "<,>": 
                case "<;>": 
                case "<с>": 
                case "<<>": 
                case "<>>": 
                case "<&>": 
                case "<=>": 
                case "<|>": 
                case "<!>": 
                case "<(>": 
                case "<)>": 
                case "<[>": 
                case "<]>": 
                case "<{>": 
                case "<}>": 
                case "<o>": Analyse(); break;
                default: throw new Exception("Недопустимый символ");
            }
        }
    }
}
