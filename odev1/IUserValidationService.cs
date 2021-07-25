using System;
using System.Collections.Generic;
using System.Text;

namespace odev1
{
    interface IUserValidationService
    {//burada sanal bir kullanıcı oluşturup doğru mu yanlışmı kontrol ediliyor.
        bool Validate(User user);

        //interface miras almaz 
    }
}
