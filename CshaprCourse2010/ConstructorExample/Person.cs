using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorExample
{
    public class Person
    {
        public string name;
        public int age;
        public Company company;


        /* На уровне кода конструктор представляет метод, 
        который называется по имени класса, 
        который может иметь параметры, 
        но для него не надо определять возвращаемый тип. 
        Например, определим в классе Person простейший конструктор:
        */


        // создание нескольких конструкторов

        //public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор
        //public Person(string n) { name = n; age = 18; }         // 2 конструктор
        //public Person(string n, int a) { name = n; age = a; }   // 3 конструктор


        // this

        /*
        Ключевое слово this представляет ссылку на текущий экземпляр/объект класса.
        В каких ситуациях оно нам может пригодиться?
        
         
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        */

        public void Print()
        {
            Console.WriteLine("Имя: {0}  Возраст: {1}",name,age);
        }

        // Цепочка вызова конструкторов

        public Person() : this("Неизвестно")    // первый конструктор
        { }
        public Person(string name) : this(name, 18) // второй конструктор
        { }
        public Person(string name, int age)     // третий конструктор
        {
            this.name = name;
            this.age = age;
        }

        // Определение значений по умолчанию

        /*
            public Person(string name = "Неизвестно", int age = 18)
            {
                this.name = name;
                this.age = age;
            }
        */


        // Деконструкторы позволяют выполнить декомпозицию объекта на отдельные части.

        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        }

    }
}
