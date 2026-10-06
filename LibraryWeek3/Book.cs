using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeek3
{
    public class Book
    {
        string Title;
        string Author;
        string ISBN;

        public Book(string bookTitle, string bookAuthor, string BookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = BookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();


        }

    }
}
