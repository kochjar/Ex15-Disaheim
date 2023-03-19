using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class Controller
    {
        private MerchandiseRepository _merchandiseRepository;
        private CourseRepository _courseRepository;

        public Controller() {
            _merchandiseRepository= new MerchandiseRepository();
            _courseRepository = new CourseRepository();
        }

        public void AddToList(Merchandise merchandise)
        {
            _merchandiseRepository.AddMerchandise(merchandise);
        }

        public void AddToList(Course course)
        {
            _courseRepository.AddCourse(course);
        }
    }
}
