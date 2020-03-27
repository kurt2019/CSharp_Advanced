using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 10. Добавьте интерфейс, добавьте метод и свойство, ваш класс(изначальный) должен реализовывать этот интерфейс
    interface IMyInterfase
    {
        string NameDog { get; set; }
        void PrintHello();
    }
}
