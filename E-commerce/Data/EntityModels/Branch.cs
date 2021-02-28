using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Branch
    {
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string WorkingHours { get; set; }
        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }
        public int CityId { get; set; }
    }
}
