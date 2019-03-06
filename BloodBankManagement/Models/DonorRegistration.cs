using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BloodBankManagement.Models
{
    [Table("DonorRegistration")]
    public class DonorRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Blood_Group{ get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
    }
}