﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class Amulet : Merchandise
    {
        public Level Quality { get; set; }
        public string Design { get; set; }
        

        public Amulet(string itemId, Level quality, string design) {
            this.ItemId = itemId;
            this.Quality = quality;
            this.Design = design;
        }

        public Amulet(string itemId, Level quality) : this(itemId, quality, ""){}

        public Amulet(string itemId) : this(itemId, Level.medium, ""){}
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
