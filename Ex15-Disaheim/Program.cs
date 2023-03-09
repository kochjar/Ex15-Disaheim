namespace Ex15_Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Level level = Level.low;
            Console.Write(level);

            Book b1 = new Book("1");
            Book b2 = new Book("2", "Falling in Love with Yourself");
            Book b3 = new Book("3", "Spirits in the Night", 123.55);

            Amulet a1 = new Amulet("11");
            Amulet a2 = new Amulet("12", Level.high);
            Amulet a3 = new Amulet("13", Level.low, "Capricorn");

            Controller controller = new Controller();

            
            
            controller.AddToList(b3);/*
            controller.AddToList(b2);
            controller.AddToList(b3);

            controller.AddToList(a1);
            controller.AddToList(a2);
            controller.AddToList(a3);*/
        }
    }
}