using Core.Interfaces;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
   public  class SortTypeService : ISortTypeService
    {
        public List<SortTypeVM> GetSortType()
        {
            List<SortTypeVM> SortType = new List<SortTypeVM>();
            SortType.Add(new SortTypeVM() { Name = "Price: Low to high", ID = 1 });
            SortType.Add(new SortTypeVM() { Name = "Price: High to low", ID = 2 });
            SortType.Add(new SortTypeVM() { Name = "By name", ID = 3 });
            return SortType;
        }

    }
}
