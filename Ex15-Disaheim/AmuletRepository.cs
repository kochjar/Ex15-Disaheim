using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Ex15_Disaheim
{
    internal class AmuletRepository
    {
        private List<Amulet> amulets { get; set; }

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemId)
                {
                    return amulet;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            Utility utility = new Utility();

            foreach (Amulet amulet in amulets)
            {
                //sum += amulets.Price;
                sum += utility.GetValueOfAmulet(amulet);
            }

            return sum;
        }
    }
}
