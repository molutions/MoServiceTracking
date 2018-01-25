using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using MoServiceTracking.Models;
using System.Linq;
using System.Web;

namespace MoServiceTracking.Persistence.EntityConfigurations
{
    public class CustomerConfiguration:EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
           
        }
    }
}