
using UtilityLib;
using static System.Reflection.Metadata.BlobBuilder;

namespace Ex15_Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1, b2, b3;
            Amulet a1, a2, a3;
            Course c1, c2;

            CourseRepository courses;
            BookRepository books;
            AmuletRepository amulets;
            // Arrange
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);

            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.high);
            a3 = new Amulet("13", Level.low, "Capricorn");

            c1 = new Course("Eufori med røg");
            c2 = new Course("Nuru Massage using Chia Oil", 157);

            courses = new CourseRepository();
            books = new BookRepository();
            amulets = new AmuletRepository();

            // Act
            books.AddBook(b1);
            books.AddBook(b2);
            books.AddBook(b3);

            amulets.AddAmulet(a1);
            amulets.AddAmulet(a2);
            amulets.AddAmulet(a3);

            courses.AddCourse(c1);
            courses.AddCourse(c2);

            Console.WriteLine(books.GetBook("2"));
            Console.WriteLine(b2);
        }
    }
}