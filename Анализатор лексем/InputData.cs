using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public static class InputData
    {
        public static string Data { get; set; } = "if (a ! 5 ) 6, 3 {a = 122;};";
        public static int Pointer { get; set; } = 0;

        public static char Current { get { return Data[Pointer]; } }


        public static string CurentCharGroup()
        {
            if (Current >= '0' && Current <= '9')
                return "<цифра>";
            else if (Current >= 'a' && Current <= 'z' || Current >= 'A' && Current <= 'Z' || Current == '_')
                return "<буква>";
            else if (Current == ' ') return "< >";           
            else if (Current == ',') return "<,>";
            else if (Current == ';') return "<;>";
            else if (Current == '+' || Current == '-' || Current == '*' || Current == '/' || Current == '%')
                return "<с>";
            else if (Current == '<') return "<<>";
            else if (Current == '>') return "<>>";
            else if (Current == '=') return "<=>";
            else if (Current == '#') return "<#>";
            else if (Current == '!') return "<!>";
            else if (Current == '(') return "<(>";
            else if (Current == ')') return "<)>";
            else if (Current == '[') return "<[>";
            else if (Current == ']') return "<]>";
            else if (Current == '{') return "<{>";
            else if (Current == '}') return "<}>";
            else if (Current >= 'а' && Current <= 'я' || Current >= 'А' && Current <= 'Я' || Current == '?' || Current == '.')
                return "<O>";
            else throw new ArgumentOutOfRangeException($"Cимвол <{Current}> недопустим в грамматике");
        }
    }
}
