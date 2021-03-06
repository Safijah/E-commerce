using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class ItemService : IItemService
    {
        private E_commerceDB _context;
        public ItemService(E_commerceDB context)
        {
            _context = context;
            
        }
        public GetItemVM GetAll()
        {
            var items = _context.Item.Select(a => new GetItemVM.Rows
            {
                ID = a.ID,
                SerialNumber = a.SerialNumber,
                Name = a.Name,
                Description = a.Description,
                Price = a.Price,
                BrandCategory = _context.BrandCategory.Where(b => b.ID == a.BrandCategoryID).FirstOrDefault().Name,
                GenderCategory = _context.GenderSubCategory.Where(c => c.ID == a.GenderSubCategoryID).FirstOrDefault().GenderCategory.Name,
                SubCategory = _context.GenderSubCategory.Where(d => d.ID == a.GenderSubCategoryID).FirstOrDefault().SubCategory.Name,
                Image= _context.ItemImage.Where(f=>f.ItemID==a.ID).FirstOrDefault().Image

            }).ToList();
            GetItemVM vm = new GetItemVM();
            vm.Items = items;
            return vm;


        }

        public Item GetItem(int id)
        {
            return _context.Item.First(x => x.ID == id);
        }
    }
}
