using Core.Interfaces;
using Data.DbContext;
using Data.ViewModels;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Core.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private E_commerceDB _context;
        public ShoppingCartService(E_commerceDB context)
        {
            _context = context;
        }
        public void ShoppingCart(ShoppingCartVM cart)
        {
            ShoppingCart ShoppingCart = new ShoppingCart() 
            {
            TotalPrice=cart.totalprice,
            Date=DateTime.Now,
            Address=cart.adress,
            City=cart.city,
            CustomerID=cart.customerId,
            BranchID=cart.branchId,
            CheckID=5

            };
            _context.Add(ShoppingCart);
            _context.SaveChanges();
            foreach(var x in cart.Orders)
            {
                var order = new Order()
                {
                    Date = DateTime.Now,
                    UnitCost = x.unitcost,
                    Quantity = x.quantity,
                    ItemSizeID = x.itemsizeId,
                    ShoppingCartID = ShoppingCart.ID
                };
                var inventory = _context.Inventory.First(a=>a.ID==x.inventoryId && a.ItemSizeID==x.itemsizeId && a.BranchID== cart.branchId);
                inventory.Quantity = inventory.Quantity - x.quantity;
                if (inventory.Quantity <= 0)
                {
                    inventory.IsAvailable = false;
                }
                _context.SaveChanges();
                _context.Add(order);
                _context.SaveChanges();
            }
                var customer = _context.Customer.First(a => a.ID == ShoppingCart.CustomerID);
                customer.TotalSpent += ShoppingCart.TotalPrice;
                _context.SaveChanges();
        }
    }
}
