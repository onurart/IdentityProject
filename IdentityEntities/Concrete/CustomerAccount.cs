using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityEntities.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrecy { get; set; }
        public decimal CustomerAccounBalance { get; set; }
        public string BankBranh { get; set; }
        public int AppUserID {  get; set; }
        public AppUser AppUser {  get; set; }
    }
}
