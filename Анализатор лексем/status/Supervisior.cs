using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public static class Supervisior 
    {
        public static void END(string data)
        {
            Console.WriteLine($"Распознана лексема: <{InputData.Current}> - {data};");
            InputData.Pointer++;
        }

        public static void Analyse()
        {
            while (InputData.Pointer < InputData.Data.Length)
            {
                switch (InputData.CurentCharGroup())
                {
                    case "<цифра>":
                        Num.Analyse();
                        break;

                    case "<буква>":
                        Id.Analyse();
                        break;

                    case "< >":
                        InputData.Pointer++;
                        break;
                    case "<,>":
                        END("Распознана <,>");
                        break;

                    case "<;>":
                        END("Распознана <;>");
                        break;

                    case "<с>":
                        END("математический оператор");
                        break;

                    case "<<>":
                        Less.Analyse();
                        break;

                    case "<>>":
                        More.Analyse();
                        break;
                    case "<!>":
                        NotEqual.Analyse();
                        break;
                    case "<#>":
                        Equal.Analyse();
                        break;
                    case "<=>":
                        END("оператор присваивания");
                        break;                   
                    case "<(>":
                        END("Распознана <(>");
                        break;

                    case "<)>":
                        END("Распознана <)>");
                        break;

                    case "<[>":
                        END("Распознана <[>");
                        break;

                    case "<]>":
                        END("Распознана <]>");
                        break;
                    case "<{>":
                        END("Распознана <{>");
                        break;

                    case "<}>":
                        END("Распознана <}>");
                        break;

                    case "<O>":
                        throw new Exception("Недопустимый символ.");

                    default:
                        throw new Exception("Недопустимый символ.");
                }
            }
        }
    }
}
