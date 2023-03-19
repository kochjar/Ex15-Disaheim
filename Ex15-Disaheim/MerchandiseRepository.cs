using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Reflection.Metadata.BlobBuilder;

namespace Ex15_Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                {
                    return merchandise;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            Utility utility = new Utility();

            foreach (Merchandise merchandise in merchandises)
            {
                sum += utility.GetValueOfMerchandise(merchandise);
            }

            return sum;
        }
    }
}
