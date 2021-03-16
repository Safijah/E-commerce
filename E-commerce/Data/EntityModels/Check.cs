using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Check
    {
        public int ID { get; set; }
        public float Price { get; set; }
        public double Discount { get; set; }
        public float TotalPrice { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey(nameof(PaymentMethodID))]
        public virtual PaymentMethod PaymentMethod { get; set; }
        public int PaymentMethodID { get; set; }
        [ForeignKey(nameof(CouponID))]
        public virtual Coupon Coupon { get; set; }
        public int? CouponID { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public HistoryOfPayments HistoryOfPayments { get; set; }
    }
}
