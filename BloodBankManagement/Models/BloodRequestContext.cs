using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BloodBankManagement.Models
{
    public class BloodRequestContext :DbContext
    {
        public DbSet<BloodRequest> BloodRequests { get; set; }
    }
}