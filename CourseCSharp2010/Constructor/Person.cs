using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Person
    {
        public string name;
        public int age;
        public Company company;
        
        
        public void Print()
        {
            Console.WriteLine("Имя: {0}  Возраст: {1}",name,age);
        }
        /*
        */
        public void PrintCompany()
        {
            Console.WriteLine("Компания: {0}", company.title);
        }
        


        // чтобы конструктор был доступен вне класса Person, он определен с модификатором public

        /* 
        public Person()
        {
            Console.WriteLine("Создание объекта Person");
            name = "Tom";
            age = 37;
        }
        */



        // Определение нескольких конструкторов
        /* 

        // 1 конструктор
        public Person() {
            name = "Неизвестно";
            age = 18;
        }

        // 2 конструктор
        public Person(string n) {
            name = n;
            age = 18;
        }

        // 3 конструктор
        public Person(string n, int a) {
            name = n;
            age = a;
        }   
      
          */


        // Ключевое слово this
        /*
        Ключевое слово this представляет ссылку на текущий экземпляр/объект класса.
        В каких ситуациях оно нам может пригодиться?
        */

        /*    */
        public Person(string name, int age) 
        { 
            this.name = name; 
            this.age = age; 
        }
      


        // Цепочка вызова конструкторов

        /* 

        public Person() : this("Неизвестно") // первый конструктор
        { }
        public Person(string name) : this(name, 18) // второй конструктор
        { }
        public Person(string name, int age) // третий конструктор
        {
            this.name = name;
            this.age = age;
        }
        */

        // Значения по умолчанию

        /* 
        public Person(string name = "Неизвестно", int age = 18)
        {
            this.name = name;
            this.age = age;
        }
       */

        // Инициализаторы объектов
        /*
         
         
         
         Для инициализации объектов классов можно применять инициализаторы. 
         Инициализаторы представляют передачу в фигурных скобках значений доступным полям и свойствам объекта:
         
         С помощью инициализатора объектов можно присваивать значения всем доступным полям
         и свойствам объекта в момент создания. При использовании инициализаторов следует 
         учитывать следующие моменты:
         
         - С помощью инициализатора мы можем установить значения
         только доступных из вне класса полей и свойств объекта. 
         Например, в примере выше поля name и age имеют модификатор доступа public,
         поэтому они доступны из любой части программы.

         Инициализатор выполняется после конструктора, поэтому если и в конструкторе,
         и в инициализаторе устанавливаются значения одних и тех же полей и свойств,
         то значения, устанавливаемые в конструкторе, заменяются значениями из инициализатора.

         Инициализаторы удобно применять, когда поле или свойство класса представляет другой класс: 
          
         Person tom = new Person{ name = "Tom", company = { title = "Microsoft"} }; 
         
         

         
         */

        // Деконструкторы
        /*
         
        Деконструкторы (не путать с деструкторами) 
        позволяют выполнить декомпозицию объекта на отдельные части.
        
        
         */

        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        } 
        

         
        

















    }
}
