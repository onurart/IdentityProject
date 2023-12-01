using IdentityBussines.Abstract;
using IdentityDataAccesLayer.Abstract;
using IdentityEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityBussines.Concrete
{
    public class CustomerAccuntManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountProcessDal;
        public CustomerAccuntManager(ICustomerAccountDal customerAccountProcessDal)
        {
           _customerAccountProcessDal = customerAccountProcessDal;
        }
        public void TDelete(CustomerAccount t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustomerAccount TGetByID(int id)
        {
         return _customerAccountProcessDal.GetByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void TInsert(CustomerAccount t)
        {
                _customerAccountProcessDal.Insert(t);
        }

        public void TUpdate(CustomerAccount t)
        {
           _customerAccountProcessDal.Update(t);
        }
    }
}
