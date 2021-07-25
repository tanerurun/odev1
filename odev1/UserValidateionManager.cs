using System;
using System.Collections.Generic;
using System.Text;

namespace odev1
{
    class UserValidateionManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if(user.BirthYear==1986
                && user.FirstName=="Taner"
                && user.LastName=="ürün "
                && user.IdentityNumber==3333 )
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
