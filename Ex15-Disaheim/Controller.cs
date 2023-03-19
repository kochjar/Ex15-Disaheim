using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class Controller
    {
        private BookRepository _bookRepository;
        private AmuletRepository _amuletRepository;
        private CourseRepository _courseRepository;

        public Controller() {
            _bookRepository = new BookRepository();
            _amuletRepository= new AmuletRepository();
            _courseRepository = new CourseRepository();
        }

        public void AddToList(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void AddToList(Amulet amulet) { 
            _amuletRepository.AddAmulet(amulet);
        }

        public void AddToList(Course course)
        {
            _courseRepository.AddCourse(course);
        }
    }
}
