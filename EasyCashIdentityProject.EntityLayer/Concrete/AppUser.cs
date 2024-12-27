using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class AppUser :IdentityUser<int>
    {
        //Bu class içerisine eklenen bilgiler AspNetUsers tablona eklenecektir.
        //Context sınıfına dbset olarak eklenmesine gerek yok. Buraya eklemek yeterli
        public string Name { get; set; }
        public string Surname { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
