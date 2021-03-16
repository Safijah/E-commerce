using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public  interface IShoppingCartService
    {
        public void ShoppingCart(ShoppingCartVM cart);
    }
}
