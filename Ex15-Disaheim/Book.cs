using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class Book
    {
        public string ItemId {get;set;}
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId, string title, double price) 
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0.0) {}

        public Book(string itemId) : this(itemId, "", 0.0) { }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
