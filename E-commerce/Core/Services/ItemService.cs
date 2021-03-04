using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
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
        public List<Item> GetAll()
        {
            return _context.Item.ToList();
        }

        public Item GetItem(int id)
        {
            return _context.Item.First(x => x.ID == id);
        }
    }
}
