using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Анализатор_лексем
{
    public static class S 
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
                    case "<ц>":
                        NUM.Analyse();
                        break;

                    case "<б>":
                        ID.Analyse();
                        break;

                    case "< >":
                        InputData.Pointer++;
                        break;

                    case "<\">":
                        STR.Analyse();
                        break;

                    case "<,>":
                        END("разделительный символ");
                        break;

                    case "<;>":
                        END("концевой символ");
                        break;

                    case "<с>":
                        END("математический оператор");
                        break;

                    case "<<>":
                        LESS.Analyse();
                        break;

                    case "<>>":
                        MORE.Analyse();
                        break;

                    case "<=>":
                        END("оператор присваивания");
                        break;

                    case "<&>":
                        AND.Analyse();
                        break;

                    case "<|>":
                        OR.Analyse();
                        break;
                    case "<!>":
                        NOT.Analyse();
                        break;

                    case "<(>":
                        END("символ группировки");
                        break;

                    case "<)>":
                        END("символ группировки");
                        break;

                    case "<[>":
                        END("символ группировки");
                        break;

                    case "<]>":
                        END("символ группировки");
                        break;
                    case "<{>":
                        END("символ группировки");
                        break;

                    case "<}>":
                        END("символ группировки");
                        break;

                    case "<o>":
                        throw new Exception("Недопустимый символ.");

                    default:
                        throw new Exception("Недопустимый символ.");
                }
            }
        }
    }
}
