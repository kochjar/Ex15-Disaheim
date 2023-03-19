using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20;
                case Level.high:
                    return 27.5;
                default:
                    return 0;
            }
        }

        public double GetValueOfCourse(Course course)
        {   
            if (course == null) { return 0; }

            // Påbegyndte timer
            int hours = course.DurationInMinutes / 60;
            // Minuter i overskud.
            double remaingMinutes = course.DurationInMinutes % 60;

            if (remaingMinutes > 0) { return (hours + 1) * 875; }
            else { return hours * 875; }
        }

    }
}
