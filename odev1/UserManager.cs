using System;
using System.Collections.Generic;
using System.Text;

namespace odev1
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user))
            {
                Console.WriteLine(" Kullanıcı Kayıt Oldu.");
            }
            else if(_userValidationService.Validate(user)==false)
            {
                Console.WriteLine("Kullanıcı üye girişi yapmadı.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
           
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
