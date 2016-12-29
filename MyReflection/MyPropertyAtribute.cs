using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReflection
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyPropertyAtribute : Attribute
    {
        public ConsoleColor color { get; set; }
        public MyPropertyAtribute()
        {
            color = ConsoleColor.Green;
        }

        public MyPropertyAtribute(ConsoleColor nameAttr)
        {
            color = nameAttr;
        }
    }
}
