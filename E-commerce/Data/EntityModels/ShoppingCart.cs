using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }
        public float TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [ForeignKey(nameof(CheckID))]
        public virtual Check Check { get; set; }
        public int CheckID { get; set; }
        [ForeignKey(nameof(CreditCardID))]
        public virtual CreditCard CreditCard { get; set; }
        public int? CreditCardID { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public virtual Customer Customer { get; set; }
        public string CustomerID { get; set; }
        [ForeignKey(nameof(BranchID))]
        public virtual Branch Branch { get; set; }
        public int? BranchID { get; set; }
    }
}
