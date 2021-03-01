using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
   public  class SizeService : ISizeService
    {
        private E_commerceDB _context;
        public SizeService(E_commerceDB context)
        {
            _context = context;
        }
        public List<Size> GetAll()
        {
            return _context.Size.ToList();
        }
    }
}
