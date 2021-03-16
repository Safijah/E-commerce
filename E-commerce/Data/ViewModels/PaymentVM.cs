using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
    public class PaymentVM
    {
        public string CardNumber { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Cvc { get; set; }
        public float TotalPrice { get; set; }
        public string CustomerID { get; set; }
    }
}
