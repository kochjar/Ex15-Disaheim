using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public override string ToString() {
            // Skal formatteres som "ItemId: 100"
            return $"ItemId: {this.ItemId}";
        }

        public double GetValue()
        {
            if (this is Book book)
            {
                return book.Price;
            }
            else if (this is Amulet amulet)
            {
                switch (amulet.Quality)
                {
                    case Level.low:
                        return Amulet.LowQualityValue;
                    case Level.medium:
                        return Amulet.MediumQualityValue;
                    case Level.high:
                        return Amulet.HighQualityValue;
                    default:
                        return 0;
                }
            }
            return 0;
        }
    }
}
