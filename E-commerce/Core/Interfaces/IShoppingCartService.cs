﻿using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public  interface IShoppingCartService
    {
        public  Task ShoppingCartAsync(ShoppingCartVM cart);
    }
}
