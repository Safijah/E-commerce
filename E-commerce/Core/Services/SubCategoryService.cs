using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using Microsoft.EntityFrameworkCore;
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
       public  List<SubCategory> GetSubCategory(int id)
        {
            List<GenderSubCategory> genderSubCategories = _context.GenderSubCategory.Where(a => a.GenderCategoryID == id).ToList();
            List<SubCategory> subCategories = new List<SubCategory>();
            foreach(var x in genderSubCategories)
            {
                subCategories.Add(_context.SubCategory.Where(a => a.ID == x.SubCategoryID).FirstOrDefault());
            }
            return subCategories;
        }
    }
}
