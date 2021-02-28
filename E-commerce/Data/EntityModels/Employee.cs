using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
   public  class Employee
    {
        [Key, ForeignKey("Account")]
        public string ID { get; set; }
        public virtual  Account Account { get; set; }
        [ForeignKey(nameof(BranchID))]
        public virtual Branch Branch { get; set; }
        public int BranchID { get; set; }
    }
}
