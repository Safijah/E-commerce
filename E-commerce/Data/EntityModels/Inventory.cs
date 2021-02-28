using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        [ForeignKey(nameof(BranchID))]
        public virtual Branch Branch { get; set; }
        public int BranchID { get; set; }
        [ForeignKey(nameof(ItemSizeID))]
        public virtual ItemSize ItemSize { get; set; }
        public int ItemSizeID { get; set; }
    }
}
