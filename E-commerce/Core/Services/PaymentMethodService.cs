using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{

    public class PaymentMethodService : IPaymentMethodService
    {
        private E_commerceDB _context;
        public PaymentMethodService(E_commerceDB context)
        {
            _context = context;
        }
        public List<PaymentMethod> GetPaymentMethod()
        {
            return _context.PaymentMethod.ToList();
        }
    }
}
