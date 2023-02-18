using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person tom = new Person();  // Создание объекта Person
            //tom.Print();

            //Person bobby = new Person();
            //bobby.Print();


            // Инициализаторы

            /*  */
            //Person tom = new Person() { name = "Tom", age = 31, company = new Company(){ title = "Microsoft" } };
            //tom.Print();
            //tom.PrintCompany();
           

            // Деконструкторы

            // (string name, int age) = person; // not supported in vs2010
            // (_, int age) = person;
            

            /* */
            Person jack = new Person("Jack", 18);
            string name1;
            int age1;


            jack.Deconstruct(out name1, out age1);

            Console.WriteLine("Имя: {0}, возраст: {1}",name1, age1);
           
        }
    }
}
