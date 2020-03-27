using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 16. Добавьте enum для дней недели
    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    // 1. Создали класс
    // 9. Ваш изначальный класс должен унаследовать абстрактный и переопределить методы
    // 10. Добавьте интерфейс, добавьте метод и свойство, ваш класс(изначальный) должен реализовывать этот интерфейс
    // 14. Запретите наследование вашего основного класса(sealed)
    public sealed class MyClass : AbstractClass , IMyInterfase , IMyInterfase2
    {
        // 3. Добавили 2 поля
        private int yearsForWork = 1488;
        private string city = "Bucha";

        // 7. Статический метод и поле, для подсчета количества созданных объектов
        // Статическое поле для подщета обэктов
        public static int count;

        // 4. Добавили свойства для этих полей, одно свойство только get, другое get/set, но сет только для класса (модификатор доступа)
        public int YearsForWork
        {
            get
            {
                return yearsForWork;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            private set
            {
                city = value;
            }
        }
        // 2. Добавили в него 3 свойства
        public string Name { get; set; }
        public string Work { get; set; }
        public int Age { get; set; }

        // 10. Добавьте интерфейс, добавьте метод и свойство, ваш класс(изначальный) должен реализовывать этот интерфейс
        public string NameDog { get; set; } = "Airon";



        #region Cоздание 2 методов
        // 6. 2 метода - один возвращает значение, другой нет, один с параметрами, другой без
        // Метод которий принимает и возвращает значения
        public string FullInfo(string Name, string Work, int Age)
        {
            return $"Имя = {Name}, Робота = {Work}, Сколько год = {Age}";
        }

        // Метод которий ничего не принимает и не возвращает
        public void MethodName()
        {
            Console.WriteLine("Метод ничего не возвращает кроме этой строки");
        }
        #endregion

        // 7. Статический метод и поле, для подсчета количества созданных объектов
        // Тут надо зделать как то подщет обэктов через этот метод. Когда создаетса обэкт класа щетчик инкриментитса
        public static void StaticCounting()
        {
            int count = 1;
            ++count;
            Console.WriteLine($"На данний момент создано: {count}");
        }
        #region Переопределение методов из абстрактного класса
        // 9. Ваш изначальный класс должен унаследовать абстрактный и переопределить методы
        // Реализуем методи абстрактного класа
        public override void Look()
        {
            Console.WriteLine("Абстрактний метод кторий реализований в другом класе");
        }

        public override void SayMethod()
        {
            Console.WriteLine("Этот метод виртуальний и его можно переопредилить");
        }
        #endregion

        #region IMyInterfase
        // 10. Добавьте интерфейс, добавьте метод и свойство, ваш класс(изначальный) должен реализовывать этот интерфейс
         void IMyInterfase.PrintHello()
        {
            Console.WriteLine($"Hello {NameDog}!");
        }
        #endregion

        #region IMyInterfase2
        //  11. Добавьте интерфейс, в нем метод, полностью совпадающий с методом из интерфейса с задания 10. 
        //  Класс должен реализовать разное поведение метода, который он реализует от разных интерфейсов Подсказка
        //  %InterfaceName%.%MethodName%
        void IMyInterfase2.PrintHello()
        {
            Console.WriteLine($"Hello Problem {NameDog}!");
        }
        #endregion

        #region Переопределение методов
        //  Переопределите метод ToString и Equals для вашего класса
        public override string ToString()
        {
            return "Наш созданий класс MyClass";
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion



        // 5. Конструктор с параметрами на 3 поля которые были в начале
        public MyClass(string _Name, string _Work, int _Age)
        {
            Name = _Name;
            Work = _Work;
            Age = _Age;
        }

    }
}
