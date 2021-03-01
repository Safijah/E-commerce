using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    class GenderCategoryService : IGenderCategoryService
    {
        private E_commerceDB _context;
        public GenderCategoryService(E_commerceDB context)
        {
            _context = context;
        }

        public List<GenderCategory> GetAll()
        {
            return _context.GenderCategory.ToList();
        }
    }
}
