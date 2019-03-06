using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BloodBankManagement.Models
{
    public class DonorRegistrationContext : DbContext
    {
        public DbSet<DonorRegistration> Donors { get; set; }
    }
}