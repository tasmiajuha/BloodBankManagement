using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BloodBankManagement.Models
{
    public class BloodStockContext :DbContext
    {
        public DbSet<BloodStock> BloodStocks { get; set; }
    }
}