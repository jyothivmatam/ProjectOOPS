using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserVadalitaonManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "ENGİN"
                && gamer.LastName == "DEMİROĞ")
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
