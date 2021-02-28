using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Item
    {
        public int ItemID { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
      
        public string Images { get; set; }
        [ForeignKey(nameof(BrandCategoryID))]
        public virtual BrandCategory BrandCategory { get; set; }
        public int BrandCategoryID { get; set; }
        [ForeignKey(nameof(GenderCategoryID))]
        public virtual GenderCategory GenderCategory { get; set; }
        public int GenderCategoryID { get; set; }
        [ForeignKey(nameof(SubCategoryID))]
        public virtual SubCategory SubCategory { get; set; }
        public int SubCategoryID { get; set; }
    }
}
