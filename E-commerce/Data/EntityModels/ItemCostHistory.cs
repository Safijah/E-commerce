using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class ItemCostHistory
    {
        public int ID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public float PreviousPrice { get; set; }
        public float CurrentPrice { get; set; }
        [ForeignKey(nameof(ItemID))]
        public virtual Item Item { get; set; }
        public int ItemID { get; set; }
    }
}
