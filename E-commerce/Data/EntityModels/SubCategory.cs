using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class SubCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public virtual Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}
