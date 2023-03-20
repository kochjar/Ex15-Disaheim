using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        private static double _courseHourValue = 875;
        static public double CourseHourValue
        {
            get { return _courseHourValue; }
            set { _courseHourValue = value; }
        }

        public Course(string name)
        {
            this.Name = name;
            this.DurationInMinutes = 0;
        }
        public Course(string name, int durationInMinutes) : this(name)
        {
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }
        public double GetValue()
        {
            // Påbegyndte timer
            int hours = DurationInMinutes / 60;
            // Minuter i overskud.
            double remaingMinutes = DurationInMinutes % 60;

            if (remaingMinutes > 0) { return (hours + 1) * CourseHourValue; }
            else { return hours * CourseHourValue; }
        }
    }
}
