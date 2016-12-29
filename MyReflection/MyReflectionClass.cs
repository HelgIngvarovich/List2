using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyReflection
{
    public class MyReflectionClass
    {

        public void ColorPrint(object obj)
        {
            // Получение списка свойств и полей класса с атрибутом MyAttr
            List<MemberInfo> options = obj.GetType().GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(n => Attribute.IsDefined(n, typeof(MyPropertyAtribute))).ToList();
            // Для каждого члена с атрибутом MyAttr
            int i = 1;
            foreach (MemberInfo info in options)
            {
                MyPropertyAtribute myAttr = (MyPropertyAtribute)info.GetCustomAttributes(typeof(MyPropertyAtribute), true)[0];

                Console.WriteLine(obj.ToString() + "Color " + i + "=" + myAttr.color);
                i++;
            }
            Console.ReadLine();
        }
    }
}
