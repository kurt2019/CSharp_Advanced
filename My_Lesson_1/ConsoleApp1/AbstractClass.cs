using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 8. Абстрактный класс с абстрактным и виртуальным методом
    public abstract class AbstractClass
    {
        // Метод ниочем надо переопредилить
        public abstract void Look();

        // Метод которий нужно переопредилить в родительском класе
        public virtual void SayMethod()
        {
            Console.WriteLine("Этот метод виртуальний и его можно переопредилить");
        }
    }
}
