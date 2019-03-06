using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BloodBankManagement.Models
{
    [Table("BloodStock")]
    public class BloodStock
    {
        public int Id { get; set; }
        public string Apos { get; set; }
        public string Aneg { get; set; }
        public string Bpos{ get; set; }
        public string Bneg{ get; set; }
        public string Opos { get; set; }
        public string Oneg { get; set; }
        public string ABpos { get; set; }
        public string ABneg { get; set; }
    }
}