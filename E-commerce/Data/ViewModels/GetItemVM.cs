using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
    public class GetItemVM
    {
        public class Rows
        {
            public int ID { get; set; }
            public string SerialNumber { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public float Price { get; set; }
            public string BrandCategory { get; set; }
            public string GenderCategory { get; set; }
            public string SubCategory { get; set; }
            public byte[] Image { get; set; }

        }
        public List<Rows> Items { get; set; }
    }
}
