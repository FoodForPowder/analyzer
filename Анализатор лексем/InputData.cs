using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Анализатор_лексем
{
    public static class InputData
    {
        public static string Data { get; set; } = " private double; private;";
        public static int Pointer { get; set; } = 0;

        public static char Current { get { return Data[Pointer]; } }


        public static string CurentCharGroup()
        {
            if (Current >= '0' && Current <= '9')
                return "<ц>";
            else if (Current >= 'a' && Current <= 'z' || Current >= 'A' && Current <= 'Z' || Current == '_')
                return "<б>";
            else if (Current == ' ') return "< >";
            else if (Current == '\"') return "<\">";
            else if (Current == ',') return "<,>";
            else if (Current == ';') return "<;>";
            else if (Current == '+' || Current == '-' || Current == '*' || Current == '/' || Current == '%')
                return "<с>";
            else if (Current == '<') return "<<>";
            else if (Current == '>') return "<>>";
            else if (Current == '=') return "<=>";
            else if (Current == '&') return "<&>";
            else if (Current == '|') return "<|>";
            else if (Current == '!') return "<!>";
            else if (Current == '(') return "<(>";
            else if (Current == ')') return "<)>";
            else if (Current == '[') return "<[>";
            else if (Current == ']') return "<]>";
            else if (Current == '{') return "<{>";
            else if (Current == '}') return "<}>";
            else if (Current >= 'а' && Current <= 'я' || Current >= 'А' && Current <= 'Я' || Current == '?' || Current == '.')
                return "<o>";
            else throw new ArgumentOutOfRangeException("символ \"" + Current + "\" недопустим в грамматике");
        }
    }
}
