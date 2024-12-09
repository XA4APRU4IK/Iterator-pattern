using System;
using System.Collections;
using System.Collections.Generic;
using Iterator_Pattern;
public class Program
{
    public static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));

        foreach (var book in library)
        {
            Console.WriteLine($"{book.Title}, {book.Author}, {book.Year}");
        }
    }
}
