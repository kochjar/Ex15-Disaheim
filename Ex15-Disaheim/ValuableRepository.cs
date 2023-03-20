using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex15_Disaheim
{
    public class ValuableRepository : IPersistable
    {

        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string itemId)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Course course)
                {
                    if (course.Name == itemId) return course;
                }
                else if (valuable is Merchandise merchandise)
                {
                    if (merchandise.ItemId == itemId) return merchandise;
                }

            }
            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            foreach (IValuable valuable in valuables)
            {
                sum += valuable.GetValue();
            }
            return sum;
        }

    
        public int Count()
        {
            int count = 0;

            foreach (IValuable valuable in valuables) { count++; }

            return count;
        }


        public void Save(string fileName = "ValuableRepository.txt")
        {
            List<string> lines = new List<string> { };

            foreach (IValuable valuable in valuables)
            {
                if (valuable is Book book)
                {
                    string line = $"BOOK;{book.ItemId};{book.Title};{book.Price}";
                    lines.Add(line);
                }
                else if (valuable is Amulet amulet)
                {
                    string line = $"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.Design}";
                    lines.Add(line);
                }
                else if (valuable is Course course)
                {
                    string line = $"COURSE;{course.Name};{course.DurationInMinutes}";
                    lines.Add(line);
                }
            }

            File.WriteAllLines(fileName, lines);
        }

        public void Load(string fileName = "ValuableRepository.txt")
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("No file was found.");
            }

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] lineArray = line.Split(";");

                switch (lineArray[0])
                {
                    case "BOOK":
                        Book book = new Book(
                            lineArray[1],
                            lineArray[2],
                            Convert.ToDouble(lineArray[3])

                        );
                        this.AddValuable(book);
                        break;

                    case "AMULET":
                        Amulet amulet = new Amulet(
                            lineArray[1],
                            (Level)Enum.Parse(typeof(Level), lineArray[2]),
                            lineArray[3]
                        );
                        this.AddValuable(amulet);
                        break;

                    case "COURSE":
                        Course course = new Course(
                            lineArray[1],
                            Convert.ToInt32(lineArray[2])
                        );
                        this.AddValuable(course);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
