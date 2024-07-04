using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._16
{
    class Book
    {
        private string title, author;
        public double price;

        public Book(string title, string author, double price)
        {
            if (title == "") throw new Exception();
            if (price < 0) throw new Exception();

            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override string ToString()
        {
            return $"\"{title}\" от {author}, {price}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            for(int i = 0; i < n; i++)
            {
                string answer = Console.ReadLine();
                List<string> elements = answer.Split(' ').ToList();
                string title = "";
                while (true)
                {
                    if (elements.Count != 3)
                    {
                        title += elements[0] + " "; elements.RemoveAt(0);
                    }
                    else break;
                }
                title += elements[0];
                Book book = new Book(title, elements[1], double.Parse(elements[2]));
                books.Add(book);
            }
            
            foreach(Book book in books.OrderBy(b => b.price))
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
