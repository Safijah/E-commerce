using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class CategoryService : ICategoryService
    {
        private E_commerceDB _context;
        public CategoryService(E_commerceDB context)
        {
            _context = context;
        }
        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

    }
}
