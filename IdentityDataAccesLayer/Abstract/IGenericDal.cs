using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    { 
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        void GetBuID(T t);
        void GetList(T t);
        
    }
}
