using Core.Interfaces;
using Data.DbContext;
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

       public  string GetCode()
        {
            return _context.Coupon.Where(a => a.IsValid == true).FirstOrDefault().Code;
        }
    }
}
