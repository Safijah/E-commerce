using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public  interface ISubCategoryService
    {
         List<SubCategory> GetAll();
        
    }
}
