using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class ItemImage
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        [ForeignKey(nameof(ItemID))]
        public virtual Item Item { get; set; }
        public int ItemID { get; set; }
    }
}
