using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3.OOP
{
    class User
    {
     
        // константы

        public const string type = "User";

        // поля класса

        public string name = "Undefined"; // имя
        public int age = 10; // возраст
 




        public void Print()
        {
            Console.WriteLine("Имя: {0}  Возраст: {1}",name,age);
        }



        public void GetTypeUser()
        {
            Console.WriteLine("Тип: {0}",type);
        }

    }
}
 