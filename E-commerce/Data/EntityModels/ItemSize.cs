using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class ItemSize
    {
        public int ID { get; set; }
        [ForeignKey(nameof(SizeID))]
        public virtual Size Size { get; set; }
        public int SizeID { get; set; }
        [ForeignKey(nameof(ItemID))]
        public virtual Item Item { get; set; }
        public int ItemID { get; set; }


    }
}
