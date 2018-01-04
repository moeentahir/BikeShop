using BikeShop.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.DAL
{
    public class CustomerTypeConfigurations : EntityTypeConfiguration<Customer>
    {
        public CustomerTypeConfigurations()
        {
            ToTable("Customer");
            HasOptional(p => p.BackOffice)
                .WithOptionalPrincipal(c => c.Customer)
                .Map(c => c.MapKey("CustomerId"));
        }
    }
}
