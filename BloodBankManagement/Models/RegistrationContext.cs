﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BloodBankManagement.Models
{
    public class RegistrationContext : DbContext
    {
         public DbSet<Registration> Registrations { get; set; }
    }
}
