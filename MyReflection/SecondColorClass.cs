using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReflection
{
    public class SecondColorClass
    {
        [MyPropertyAtribute]
        public ConsoleColor color { get; private set; }

        public SecondColorClass()
        {
            
        }

        public override string ToString()
        {
            return "Second class";
        }
    }
}
