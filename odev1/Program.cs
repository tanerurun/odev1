using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new NewStateUserValidationManager());
            userManager.Add(new User
            {
                Id = 1,
                BirthYear = 1954,
                FirstName = "Taner",
                LastName = "Ürün",
                IdentityNumber = 443333
                
            });
            Console.WriteLine("Hello World!");
        }
    }
}
