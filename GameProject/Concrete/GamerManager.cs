using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer )
        {
            if (userValidationService.UserCheck(gamer)==true)
            {
                Console.WriteLine("Kullanıcı eklendi...");
            }
            else
            {
                Console.WriteLine("Kayıt basarısız...");
            }

        }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi");
        }
    }
}
