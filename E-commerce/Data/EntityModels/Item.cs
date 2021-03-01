using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Item
    {
        public int ID { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
      
        public string Images { get; set; }
        [ForeignKey(nameof(BrandCategoryID))]
        public virtual BrandCategory BrandCategory { get; set; }
        public int BrandCategoryID { get; set; }
        [ForeignKey(nameof(GenderSubCategoryID))]
        public virtual GenderSubCategory GenderSubCategory { get; set; }
        public int GenderSubCategoryID { get; set; }

    }
}
