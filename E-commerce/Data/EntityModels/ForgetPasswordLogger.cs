using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
    public class ForgetPasswordLogger
    {
        public int ID { get; set; }
        [ForeignKey(nameof(AccountId))]
        public string AccountId { get; set; }
        public virtual Account Account { get; set; }
        public DateTime DateTime { get; set; }
    }
}
