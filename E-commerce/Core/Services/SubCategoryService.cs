using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
   public  class SubCategoryService: ISubCategoryService
    {
        private E_commerceDB _context;
        public SubCategoryService(E_commerceDB context)
        {
            _context = context;
        }
        public List<SubCategory> GetAll()
        {
            return _context.SubCategory.ToList();
        }
    }
}
