using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3.OOP
{


    // Определение класса

    class Person
    {

        // поля класса - переменные определенные на уровне класса Person

        // чтобы поля были доступны вне класса Person мы определяем модификатор доступа public

        public string name;
        public string age;

        // класс может определять некоторое поведение для объектов класса, для этого определяются методы

        public void Print()
        {
           Console.WriteLine("Имя: {0}  Возраст: {1}",name,age);
        }





        
        // константы класса

        public const string type = "Person";


        public void PrintConstant()
        {
            Console.WriteLine("Тип: {0}", type);
        }





    }
}
