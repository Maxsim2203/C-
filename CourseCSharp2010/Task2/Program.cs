using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            Human h1 = new Human("Коков", 20);


            Console.WriteLine(h1.Name);


            //h1.GetAge();

            Console.WriteLine(String.Format("Возраст: {0}",h1.GetAge()  ));


        }
    }
}
