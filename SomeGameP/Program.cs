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

            GamerManager gamerManager = new GamerManager(new UserValidation());
            Items items = new Items();
            items.ListItems();
            Console.WriteLine();

            Console.WriteLine("(i) Satın alımlarınız, yoğunluk nedeniyle 10 dakika içerisinde kullanılabilir olacaktır. (i)");
            //          list of registered Gamers method
            //Console.WriteLine();
            //gamerManager.List();


            //          spaces for legibility
            Console.WriteLine();
            Console.WriteLine();


            
            gamerManager.Add(new Gamer
            {
                Id = 7,
                FirstName = "DON",
                LastName = "OMAR",
                BirthDate = 2002    //accepted value is 2003
            });

        }
    }
}
