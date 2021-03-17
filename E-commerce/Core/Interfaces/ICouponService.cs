using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface ICouponService
    {
        string GetCode();
        double CheckCode(string code);
        public string GenerateChode();
        public void AddCoupon(Coupon coupon);
    }
}
