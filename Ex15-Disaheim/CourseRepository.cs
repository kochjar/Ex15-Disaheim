using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Ex15_Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string Name)
        {
            foreach (Course course in courses)
            {
                if (course.Name == Name)
                {
                    return course;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            Utility utility = new Utility();

            foreach (Course course in courses)
            {
                //sum += amulets.Price;
                sum += utility.GetValueOfCourse(course);
            }

            return sum;
        }
    }
}
