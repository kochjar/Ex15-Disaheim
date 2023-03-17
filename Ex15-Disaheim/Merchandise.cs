using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public abstract class Merchandise
    {
        public string ItemId { get; set; }

/*        public Merchandise(string itemId)
        {
            this.ItemId = itemId;
        }*/

        public override string ToString() {
            // Skal formatteres som "ItemId: 100"
            return $"ItemId: {this.ItemId}";
        }
    }
}
