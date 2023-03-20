using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string itemId)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Course course)
                {
                    if (course.Name == itemId) return course;
                }
                else if (valuable is Merchandise merchandise)
                {
                    if (merchandise.ItemId == itemId) return merchandise;
                }

            }
            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            foreach (IValuable valuable in valuables)
            {
                sum += valuable.GetValue();
            }
            return sum;
        }

    
        public int Count()
        {
            int count = 0;

            foreach (IValuable valuable in valuables) { count++; }

            return count;
        }
    }
}
