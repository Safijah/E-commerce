using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
   public  class ShoppingCartVM
    {
        public class OrderRow
        {
            public float unitcost { get; set; }
           public int quantity { get; set; }
            //public float discount { get; set; }
            public float totalpriceitem { get; set; }
            public int itemsizeId{ get; set; }
            public int inventoryId { get; set; }
            

        }
         public List<OrderRow> Orders { get; set; }
        public float totalprice { get; set; }
        public string city { get; set; }
        public string adress { get; set; }
        public string customerId { get; set; }
        public int branchId { get; set; }
        public string coupon { get; set; }


    }
}
