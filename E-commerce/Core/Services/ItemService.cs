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
        public GetItemVM GetAll(ItemFilterVM filter)
        {
            GetItemVM vm = new GetItemVM();

            vm.Items = _context.Item.
                Where(a => (a.BrandCategoryID == filter.BrandCategoryID || filter.BrandCategoryID == 0)
                && (a.GenderSubCategory.GenderCategoryID == filter.GenderCategoryID || filter.GenderCategoryID == 0) &&
               (a.GenderSubCategory.SubCategoryID == filter.SubCategoryID || filter.SubCategoryID == 0)
               && (a.GenderSubCategory.SubCategory.CategoryID == filter.CategoryID || filter.CategoryID == 0))
                .Select(a => new GetItemVM.Rows
                {
                    ID = a.ID,
                    SerialNumber = a.SerialNumber,
                    Name = a.Name,
                    Description = a.Description,
                    Price = a.Price,
                    BrandCategory = _context.BrandCategory.Where(b => b.ID == a.BrandCategoryID).FirstOrDefault().Name,
                    GenderCategory = _context.GenderSubCategory.Where(c => c.ID == a.GenderSubCategoryID).FirstOrDefault().GenderCategory.Name,
                    SubCategory = _context.GenderSubCategory.Where(d => d.ID == a.GenderSubCategoryID).FirstOrDefault().SubCategory.Name,
                    Image = _context.ItemImage.Where(f => f.ItemID == a.ID).FirstOrDefault().Image,
                    BranchID = filter.BranchID

                }).ToList();
            return vm;
        }

            public GetItemIDVM GetItem(GetItemByIDVM filter)
        {
            var item = _context.Item.Find(filter.id);
            var x = _context.GenderSubCategory.Find(item.GenderSubCategoryID);
            var b = _context.GenderCategory.Find(x.GenderCategoryID);
            var c = _context.SubCategory.Find(x.SubCategoryID);
            GetItemIDVM vm = new GetItemIDVM()
            {
                Description= item.Description,
                SerialNumber= item.SerialNumber,
                Name=item.Name,
                Price=item.Price,
                BrandCategory= _context.BrandCategory.Where(a => a.ID == item.BrandCategoryID).FirstOrDefault().Name,
                GenderCategory=b.Name,
                SubCategory=c.Name,
                Images= _context.ItemImage.Where(a => a.ItemID == item.ID).Select(a => a.Image).ToList(),
        };
        //    vm.Description = item.Description;
        //    vm.SerialNumber = item.SerialNumber;
        //    vm.Name = item.Name;
        //    vm.Price = item.Price;
        //    vm.BrandCategory = _context.BrandCategory.Where(a => a.ID == item.BrandCategoryID).FirstOrDefault().Name;
           
        //    vm.GenderCategory = b.Name;
            
        //    vm.SubCategory = c.Name;
        //    vm.Images = _context.ItemImage.Where(a => a.ItemID == item.ID).Select(a => a.Image).ToList();
            
            var size = _context.Inventory.Include(a=>a.ItemSize).Where(a=>(a.ItemSize.ItemID==item.ID)&& a.IsAvailable==true && a.BranchID==filter.branchid).ToList();
            List<object> sizes = new List<object>();
            foreach(var k in size)
            {
                sizes.Add(_context.Size.Where(a => a.ID == k.ItemSize.SizeID ).FirstOrDefault());
            }
            vm.Sizes = sizes;
            return vm;
        }

       public  GetItemVM GetBySearch(string search)
        {
            var items = _context.Item.Where(a=>(a.Name.ToLower().Contains(search.ToLower())) || (a.Description.ToLower().Contains(search.ToLower()))).
                Select(a => new GetItemVM.Rows
               {
                   ID = a.ID,
                   SerialNumber = a.SerialNumber,
                   Name = a.Name,
                   Description = a.Description,
                   Price = a.Price,
                   BrandCategory = _context.BrandCategory.Where(b => b.ID == a.BrandCategoryID).FirstOrDefault().Name,
                   GenderCategory = _context.GenderSubCategory.Where(c => c.ID == a.GenderSubCategoryID).FirstOrDefault().GenderCategory.Name,
                   SubCategory = _context.GenderSubCategory.Where(d => d.ID == a.GenderSubCategoryID).FirstOrDefault().SubCategory.Name,
                   Image = _context.ItemImage.Where(f => f.ItemID == a.ID).FirstOrDefault().Image

               }).ToList();

            GetItemVM vm = new GetItemVM();
            vm.Items = items;
            return vm;

        }
        public List<ItemVM> GetItem(List<FilterVM> filter)
        {
            List<ItemVM> vm = new List<ItemVM>();
            foreach (var x in filter)
            {
                ItemVM item  = _context.Inventory.
                    Include(a=>a.ItemSize).ThenInclude(a=>a.Item).
                    Where(a=>a.ItemSize.Size.ID==x.size && a.IsAvailable==true && a.BranchID==x.BranchID && a.ItemSize.ItemID==x.id).
                    Select(a=> new ItemVM { 
                    Description=a.ItemSize.Item.Description,
                    ID=a.ID,
                    Name=a.ItemSize.Item.Name,
                    Price=a.ItemSize.Item.Price,
                    Image= _context.ItemImage.Where(b=>b.ItemID==x.id).FirstOrDefault().Image,
                    Quantity= a.Quantity,
                    SentQuantity= x.quantity,
                    Size=a.ItemSize.Size.Name,
                    SerialNumber=a.ItemSize.Item.SerialNumber

                    }).FirstOrDefault();
                vm.Add(item);
                
            }
            return vm;
        }

    }
}
