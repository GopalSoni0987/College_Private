﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk_4_7
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    public class Bookshelf
    {
        private List<Book> books = new List<Book>();


        public Book this[string title]
        {
            get
            {
                return books.Find(book => book.Title == title);
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bookshelf bookshelf = new Bookshelf();


            bookshelf.AddBook(new Book("Book 1", "Author 1"));
            bookshelf.AddBook(new Book("Book 2", "Author 2"));
            bookshelf.AddBook(new Book("Book 3", "Author 3"));


            Book book = bookshelf["Book 2"];

            if (book != null)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
            Console.Read();
        }
    }

}
