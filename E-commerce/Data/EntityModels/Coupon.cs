using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityModels
{
    public class Coupon
    {
        public int CouponID { get; set; }
        public string Code { get; set; }
        public DateTime ExpiredDate { get; set; }
        public float Value { get; set; }
        public bool IsValid { get; set; }
    }
}
