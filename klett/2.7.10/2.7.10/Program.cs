using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._10
{
    //1.3.16
    class Book
    {
        public string title, author;
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
    class BookLibrary
    {
        List<Book> BookList;

        public void size()
        {
            Console.WriteLine(BookList.Count());
        }

        public void append(Book b)
        {
            if(!BookList.Contains(b))
                BookList.Add(b);
        }

        public void delete(string title, string author)
        {
            BookList.Remove(BookList.Find(b => b.title == title && b.author == author));
        }

        public Book getb(string title)
        {
            return BookList.Find(b => b.title == title);
        }

        public Book getba(string title, string author)
        {
            return BookList.Find(b => b.title == title && b.author == author);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
