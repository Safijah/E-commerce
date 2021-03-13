using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
    public class ItemVM
    {
       

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        //public float TotalPrice { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }

    }
}
