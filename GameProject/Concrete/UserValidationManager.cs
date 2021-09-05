using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool UserCheck(Gamer gamer)
        {
            if (gamer.FirstName == "SEFA" && gamer.LastName =="CİFTCİ" && gamer.Id  == 1 && gamer.BirthYear == 2000 && gamer.NationalIdentity ==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
