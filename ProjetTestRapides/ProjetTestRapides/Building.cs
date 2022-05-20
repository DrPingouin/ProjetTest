using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetTestRapides
{
    public abstract class Building
    {
        public string Name { get; set; }
        public bool CanProduce { get; set; } = false; 
        public List<Item> ProducingItem { get; set; }
    }
}
