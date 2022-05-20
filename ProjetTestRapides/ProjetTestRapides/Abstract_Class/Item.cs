using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetTestRapides
{
    public abstract class Item
    { 
        public string Name { get; set; }
        public long BuyValue { get; set; } = 0;
        public long SellValue { get; set; } = 0;

    }
}
