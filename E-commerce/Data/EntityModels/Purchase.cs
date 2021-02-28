using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(BranchID))]
        public virtual Branch Branch { get; set; }
        public int BranchID { get; set; }
        [ForeignKey(nameof(ItemSizeID))]
        public virtual ItemSize ItemSize { get; set; }
        public int ItemSizeID { get; set; }
        [ForeignKey(nameof(EmployeeID))]
        public virtual Employee Employee { get; set; }
        public string EmployeeID { get; set; }
    }
}
