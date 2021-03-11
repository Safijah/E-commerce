using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class Friend
    {
        public int ID { get; set; }
        public string EmailFriend { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public virtual Customer Customer  { get; set; }
        public string CustomerID   { get; set; }

    }
}
