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
    public class CustomerAccountProcessManger : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _services;

        public CustomerAccountProcessManger(ICustomerAccountProcessDal services)
        {
            _services = services;
        }

        public void TDelete(CustomerAccountProcess t)
        {
            _services.Delete(t);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _services.GetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _services.GetList();
        }

        public void TInsert(CustomerAccountProcess t)
        {
            _services.Insert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _services.Update(t);
        }
    }
}
