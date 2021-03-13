using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public  interface IItemService
    {
        GetItemIDVM GetItem(int id);
        GetItemVM GetAll(ItemFilterVM filter);
        GetItemVM GetBySearch(string search);
        List<ItemVM> GetItem(List<FilterVM> filter);

    }
}
