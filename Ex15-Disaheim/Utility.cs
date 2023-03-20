using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class Utility
    {

        private double _lowQualityValue = 12.5;
        private double _mediumQualityValue = 20;
        private double _highQualityValue = 27.5;
        private double _courseHourValue = 875;


        public double LowQualityValue { 
            get { return _lowQualityValue; } 
            set { _lowQualityValue = value; } 
        }
        public double MediumQualityValue { 
            get { return _mediumQualityValue; }
            set { _mediumQualityValue= value; } 
        }
        public double HighQualityValue { 
            get { return _highQualityValue; }
            set { _highQualityValue= value; }
        }

        public double CourseHourValue { 
            get { return _courseHourValue; }
            set { _courseHourValue= value; }
        }

        public double GetValueOfCourse(Course course)
        {   
            if (course == null) { return 0; }

            // Påbegyndte timer
            int hours = course.DurationInMinutes / 60;
            // Minuter i overskud.
            double remaingMinutes = course.DurationInMinutes % 60;

            if (remaingMinutes > 0) { return (hours + 1) * CourseHourValue; }
            else { return hours * CourseHourValue; }
        }

        public double GetValueOfMerchandise(Merchandise merchandise)
        {

            if (merchandise is Book book)
            {
                return book.Price;
            } 
            else if (merchandise is Amulet amulet)
            {
                switch (amulet.Quality)
                {
                    case Level.low:
                        return LowQualityValue;
                    case Level.medium:
                        return MediumQualityValue;
                    case Level.high:
                        return HighQualityValue;
                    default:
                        return 0;
                }
            }
            return 0;

        }

    }
}