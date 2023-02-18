using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3.OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // вызов конструктор классаы
            // new выделяет память
            
            Person p = new Person();



            // доступ и задание поля вне класса
            p.name = "Name";
            Console.WriteLine(p.name);
            
            // вызов метода
            p.Print();


            p.PrintConstant(); // обращение к константе через объект p
            Console.WriteLine(Person.type); // обращение к константе через класс Person


            
            // добавление нового класса

        }
    }
}
