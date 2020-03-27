using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("Lox", "program", 22);
            myClass.Look();
            myClass.SayMethod();

            IMyInterfase myInterfase = myClass as IMyInterfase;
            myInterfase.PrintHello();

            IMyInterfase2 myInterfase2 = myClass as IMyInterfase2;
            myInterfase2.PrintHello();

            string p = "Java";
            p.extension();

            Extensions.extension("lol");

            string str = "PHP";

            Console.WriteLine(str.AddStrings("the best", "love", "XZ"));

            string str1 = "I love ".AddStrings("PHP");

            Console.WriteLine(str1);

            Console.WriteLine(myClass);






            Console.ReadKey();
        }
    }
}
