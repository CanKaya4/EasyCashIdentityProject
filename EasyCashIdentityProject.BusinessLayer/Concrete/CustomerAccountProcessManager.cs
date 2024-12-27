using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountDal;
        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountDal = customerAccountProcessDal;
        }
        public void TDelete(CustomerAccountProcess t)
        {
            _customerAccountDal.Delete(t);
        }

        public List<CustomerAccountProcess> TGetAll()
        {
            return _customerAccountDal.GetAll();
        }

        public CustomerAccountProcess TGetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public void TInsert(CustomerAccountProcess t)
        {
            _customerAccountDal.Insert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
