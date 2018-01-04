using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain
{
    public class Customer: User
    {
        public virtual Address Address { get; set; }

        public virtual CustomerBackOffice BackOffice { get; set; }
    }
}
