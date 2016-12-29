using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyReflectionClass myClass = new MyReflectionClass();
            FirstColorClass one = new FirstColorClass();
            myClass.ColorPrint(one);
            SecondColorClass two = new SecondColorClass();
            myClass.ColorPrint(two);
        }
    }
}
