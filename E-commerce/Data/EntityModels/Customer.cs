using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Customer
    {
       [Key, ForeignKey("Account")]
        public string ID { get; set; }
        public float  TotalSpent { get; set; }
        public virtual Account Account { get; set; }
       
        

    }
}
