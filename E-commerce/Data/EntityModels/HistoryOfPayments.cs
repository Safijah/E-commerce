using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class HistoryOfPayments
    {
       
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public virtual Customer Customer { get; set; }
        public string CustomerID { get; set; }
        [ForeignKey(nameof(CheckID))]
        public virtual Check Check { get; set; }
        public int CheckID { get; set; }
    }
}
