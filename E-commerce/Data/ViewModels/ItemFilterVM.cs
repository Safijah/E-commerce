using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
   public  class ItemFilterVM
    {
        public int CategoryID { get; set; }
        public int GenderCategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int BrandCategoryID { get; set; }
        public int SortTypeID { get; set; }
        public int BranchID { get; set; }
    }
}
