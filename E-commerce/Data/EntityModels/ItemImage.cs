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

        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string ImageSrc { get; set; }


        [ForeignKey(nameof(ItemID))]
        public virtual Item Item { get; set; }
        public int ItemID { get; set; }
    }
}
