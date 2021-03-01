using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class GenderSubCategory
    {
        public int ID { get; set; }
        [ForeignKey(nameof(SubCategoryID))]
        public virtual SubCategory SubCategory { get; set; }
        public int SubCategoryID { get; set; }
        [ForeignKey(nameof(GenderCategoryID))]
        public virtual GenderCategory GenderCategory { get; set; }
        public int GenderCategoryID { get; set; }
       
    }
}
