using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class CreditCard
    {
        public int ID { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Cvc { get; set; }

        [ForeignKey(nameof(CustomerID))]
        public Customer Customer { get; set; }
        public string CustomerID { get; set; }
    }
}
