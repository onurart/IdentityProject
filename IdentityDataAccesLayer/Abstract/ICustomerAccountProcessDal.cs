using IdentityEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDataAccesLayer.Abstract
{
    public interface ICustomerAccountProcessDal : IGenericDal<CustomerAccountProcess>
    {
        void Delete(CustomerAccount t);
    }
}
