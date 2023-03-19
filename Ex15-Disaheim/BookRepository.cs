using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Ex15_Disaheim
{
    internal class BookRepository
    {
        private List<Book> books { get; set; }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            foreach (Book book in books)
            {
                if (book.ItemId == itemId)
                {
                    return book;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            Utility utility = new Utility();

            foreach (Book book in books)
            {
                sum += book.Price;
                //sum += utility.GetValueOfBook(book);
            }

            return sum;
        }

    }
}
