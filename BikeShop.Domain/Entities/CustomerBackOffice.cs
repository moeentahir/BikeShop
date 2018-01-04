using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain
{
    public class CustomerBackOffice : GuidEntity
    {
        public bool IsFavourite { get; set; }

        public DateTime? LastContactedOn { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
