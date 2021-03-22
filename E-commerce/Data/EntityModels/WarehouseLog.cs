using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class WarehouseLog
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey(nameof(BranchID))]
        public virtual Branch Branch { get; set; }
        public int BranchID { get; set; }
    }
}
