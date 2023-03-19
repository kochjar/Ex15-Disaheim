
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
            MerchandiseRepository merchandises;

            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);
            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.high);
            a3 = new Amulet("13", Level.low, "Capricorn");
            c1 = new Course("Eufori med røg");
            c2 = new Course("Nuru Massage using Chia Oil", 157);
            courses = new CourseRepository();
            merchandises = new MerchandiseRepository();
            merchandises.AddMerchandise(b1);
            merchandises.AddMerchandise(b2);
            merchandises.AddMerchandise(b3);
            Console.WriteLine(merchandises.GetTotalValue());
            merchandises.AddMerchandise(a1);
            merchandises.AddMerchandise(a2);
            merchandises.AddMerchandise(a3);
            courses.AddCourse(c1);
            courses.AddCourse(c2);

            Console.WriteLine(merchandises.GetTotalValue());
            Console.ReadLine();
        }
    }
}