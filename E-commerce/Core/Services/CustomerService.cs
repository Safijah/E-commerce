using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
   public  class CustomerService : ICustomerService
    {
        private E_commerceDB _context;
        public CustomerService(E_commerceDB E_CommerceDB)
        {
            _context = E_CommerceDB;
        }
        public void AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }
    }
}
