using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
   public  class CouponService : ICouponService
    {
        private E_commerceDB _context;
        public CouponService(E_commerceDB context)
        {
            _context = context;
        }

        public string GenerateChode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 7)
         .Select(s => s[random.Next(s.Length)]).ToArray());
        }
       public  string GetCode()
        {
            return _context.Coupon.Where(a => a.IsValid == true).FirstOrDefault().Code;
        }
       public  bool CheckCode(string code)
        {
            if (_context.Coupon.FirstOrDefault(a => a.Code == code && a.IsValid==true) != null)
                return true;
            else
                return false;

        }
        public void AddCoupon(Coupon coupon)
        {
            _context.Add(coupon);
            _context.SaveChanges();
        }
    }
    
}
