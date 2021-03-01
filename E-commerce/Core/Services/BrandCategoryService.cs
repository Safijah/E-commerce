using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
   public  class BrandCategoryService : IBrandCategoryService
    {
        private E_commerceDB _context { get; set; }
        public BrandCategoryService(E_commerceDB context)
        {
            _context = context;
        }
        public List<BrandCategory> GetAll()
        {
            return _context.BrandCategory.ToList();
        }
    }
}
