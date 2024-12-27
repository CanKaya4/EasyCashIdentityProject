using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Abstract
{
    public interface ICustomerAccountProcessDal : IGenericDal<CustomerAccountProcess>
    {
        //CustomerAccountProcess için özel metotlar yazmak için kullanıyoruz. Eğer özel metodu yoksa IGenericDal üzerinden gelen default metotlar kullanılacak.
    }
}
