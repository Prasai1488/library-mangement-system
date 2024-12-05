using System;
using System.Collections.Generic;


public class Staff : Member
{
    public Staff(string name, int id) : base(name, id)
    {
    }

    // Add a new book to the library collection
    public void AddBookToLibrary(Library library, Book book)
    {
        library.AddBook(book);
        Console.WriteLine($"{Name} added the book {book.Title} to library");
    }

    // remove a book from library: 
    public void RemoveBookFromLibrary(Library library, Book book)
    {
        library.RemoveBook(book);
        Console.WriteLine($"{Name} removed the book : {book.Title}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Staff Name : {Name}, Staff ID : {Id}");
    }
}