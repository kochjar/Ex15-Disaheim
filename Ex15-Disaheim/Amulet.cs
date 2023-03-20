using System;
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

        static private double _lowQualityValue = 12.5;
        static private double _mediumQualityValue = 20;
        static private double _highQualityValue = 27.5;

        static public double LowQualityValue
        {
            get { return _lowQualityValue; }
            set { _lowQualityValue = value; }
        }
        static public double MediumQualityValue
        {
            get { return _mediumQualityValue; }
            set { _mediumQualityValue = value; }
        }
        static public double HighQualityValue
        {
            get { return _highQualityValue; }
            set { _highQualityValue = value; }
        }

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
