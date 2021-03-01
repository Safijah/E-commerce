using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Warehouse
    {
        public int ID { get; set; }
        public int PreviousBalance { get; set; }
        public int Income { get; set; }
        public int Sold { get; set; }
        public int CurrentBalance { get; set; }
        [ForeignKey(nameof(ItemSizeID))]
        public virtual ItemSize ItemSize { get; set; }
        public int ItemSizeID { get; set; }
        [ForeignKey(nameof(BranchID))]
        public virtual Branch Branch { get; set; }
        public int BranchID { get; set; }
    }
}
