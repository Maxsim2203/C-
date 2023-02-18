using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {


            //Film film1 = new Film("Терминатор 2", "Д.Кемерон");


            Console.Write("Назовите фамилию режиссера: ");
            string name = Console.ReadLine();
            Console.WriteLine();


            int i;
            List<Film> favoriteFilms = new List<Film>();

       
            // Создание объектов класса Film

            for(i=0;i<3;i++){

                Console.WriteLine();
                Console.WriteLine(String.Format("Назовите любимый фильм режиссера:{0}",name));
                Console.WriteLine();
                
                favoriteFilms.Add(new Film(name, Console.ReadLine()));

            }

            Random rand = new Random();

           int choice = rand.Next(0,favoriteFilms.Count - 1);

           Film film = favoriteFilms[choice];


           Console.WriteLine(String.Format("И сегодня вечером рекомендую посмотреть фильм {0}",film.Title));
           Console.WriteLine(String.Format("Режиссера:  {0}",film.Producer));

        }
    }
}
