using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookclass;
namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 15);
            Book book3 = new Book("1984", "George Orwell", 20);

            book1.DisplayBookInfo();
            book2.DisplayBookInfo();
            book3.DisplayBookInfo();
        }
    }
}