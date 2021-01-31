using System;
using System.Collections.Generic;
using System.Linq;
using SomeGameP.Ops;
using SomeGameP.Validation;
using SomeGameP.Props;

namespace SomeGameP
{
    class Program
    {
        static void Main(string[] args)
        {

            Items items = new Items();
            items.ListItems();
            Console.WriteLine();

            Console.WriteLine("(i) Satın alımlarınız, yoğunluk nedeniyle 10 dakika içerisinde kullanılabilir olacaktır. (i)");
            //Gamers oko = new Gamers();
            //oko.List()}
            Console.WriteLine();
            Console.WriteLine();

            GamerManager gamerManager = new GamerManager(new UserValidation());
            gamerManager.Add(new Gamer
            {
                Id = 7,
                FirstName = "DON",
                LastName = "OMAR",
                BirthDate = 2002
            });

        }
    }
}
