using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NEwEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
