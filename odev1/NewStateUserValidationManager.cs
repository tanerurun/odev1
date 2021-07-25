using System;
using System.Collections.Generic;
using System.Text;

namespace odev1
{
    class NewStateUserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            return true;
        }
        public bool Validete(User user)
        {
            return false;
        }
    }
}
