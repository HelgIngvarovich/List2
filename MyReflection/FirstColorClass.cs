using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReflection
{
    public class FirstColorClass
    {
        [MyPropertyAtribute(ConsoleColor.DarkGreen)]
        public ConsoleColor color { get; set; }

        [MyPropertyAtribute(ConsoleColor.DarkRed)]
        public ConsoleColor color2 { get; private set; }

        [MyPropertyAtribute(ConsoleColor.Black)]
        public ConsoleColor color3 { get; private set; }

        [MyPropertyAtribute(ConsoleColor.Red)]
        public ConsoleColor color4 { get; private set; }

        public FirstColorClass()
        {

        }

        public override string ToString()
        {
            return "First class";
        }
    }
}
