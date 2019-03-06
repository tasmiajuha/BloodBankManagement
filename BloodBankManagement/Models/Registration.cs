using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BloodBankManagement.Models
{
    [Table("Registration")]
    public class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Blood_Group { get; set; }
        public string Weight{ get; set; }
        public string Height{ get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}