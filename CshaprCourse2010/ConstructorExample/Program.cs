using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {

            // Вызор нескольких конструкторов

            //Person tom = new Person();          // вызов 1-ого конструктора без параметров
            //Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
            //Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами

            // инициализация объектов

            Person tom = new Person { name = "Tom", age = 31 };

            tom.Print();          // Имя: Неизвестно  Возраст: 18

            /*
             C помощью инициализатора объектов можно присваивать значения всем доступным полям и свойствам объекта в момент создания. При использовании инициализаторов следует учитывать следующие моменты:
              
             - С помощью инициализатора мы можем установить значения только доступных из вне класса полей и свойств объекта. Например, в примере выше поля name и age имеют модификатор доступа public, поэтому они доступны из любой части программы.
             - Инициализатор выполняется после конструктора, поэтому если и в конструкторе, и в инициализаторе устанавливаются значения одних и тех же полей и свойств, то значения, устанавливаемые в конструкторе, заменяются значениями из инициализатора.
             - Инициализаторы удобно применять, когда поле или свойство класса представляет другой класс:
             
             */

            Person tom1 = new Person { name = "Tom", company = new Company(){ title = "Microsoft" } };
            tom1.Print();          // Имя: Tom  Компания: Microsoft


            //(string name, int age) = tom1; // not supported in vs2010

            string name; 
            int age;
            tom1.Deconstruct(out name, out age);
            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 18

        }
    }
}
