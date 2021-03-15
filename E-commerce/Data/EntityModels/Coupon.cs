using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityModels
{
    public class Coupon
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public DateTime ExpiredDate { get; set; }
        public double Value { get; set; }
        public bool IsValid { get; set; }
    }
}
