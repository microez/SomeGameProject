using SomeGameP.Props;
using System;
using System.Collections.Generic;
using System.Text;

namespace SomeGameP.Ops
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;
        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }



        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt edilemedi.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
        public void List()
        {
            List<Gamer> usrs = new List<Gamer>() { ku1, ku2, ku3, ku4, ku5 };
            Console.WriteLine("Kayıtlı kullanıcılar: ");
            Console.WriteLine();
            foreach (var x in usrs)
            {
                Console.WriteLine(x.FirstName + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("*Liste sonu*");
        }

        Gamer ku1 = new Gamer() { Id = 1, FirstName = "Doğan", LastName = "Kül", BirthDate = 1999, TCNo = "58299201158" };
        Gamer ku2 = new Gamer() { Id = 2, FirstName = "Zeynep", LastName = "Avşar", BirthDate = 1987, TCNo = "30018475619" };
        Gamer ku3 = new Gamer() { Id = 3, FirstName = "Eray", LastName = "Kazan", BirthDate = 2001, TCNo = "11857399244" };
        Gamer ku4 = new Gamer() { Id = 4, FirstName = "Selim", LastName = "Özkül", BirthDate = 1980, TCNo = "85993319683" };
        Gamer ku5 = new Gamer() { Id = 5, FirstName = "İpek", LastName = "West", BirthDate = 2002, TCNo = "23957381839" };


    }
}
