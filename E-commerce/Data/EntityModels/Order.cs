using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public float UnitCost { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public float TotalPrice { get; set; }
        [ForeignKey(nameof(ShoppingCartID))]
        public virtual ShoppingCart ShoppingCart { get; set; }
        public int ShoppingCartID { get; set; }
        [ForeignKey(nameof(ItemSizeID))]
        public virtual ItemSize ItemSize { get; set; }
        public int ItemSizeID { get; set; }
    }
}
