using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public  interface IItemService
    {
        Item GetItem(int id);
        List<Item> GetAll();
    }
}
