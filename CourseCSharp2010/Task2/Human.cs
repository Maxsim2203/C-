using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Human
    {
        





        public string Name { get; set; }
        public int Age { get; set; }


        public Human(string name, int age){

            Name = name;
            Age = age;
        
        }


        public int GetAge(){
        
           return this.Age;
        }



    }
}
