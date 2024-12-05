using System;
using System.Collections.Generic;


public class Book
{
    // Properties to store book details.
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsAvailable { get; set; } = true;

    // Constructor that initializes the book with title, author, and ISBN.
    public Book(string title, string author, string isbn)
    {
        Title = title; 
        Author = author;
        ISBN = isbn;

    }

    //  // Method to display book details :
    public void DisplayDetails()
    {
        Console.WriteLine($"Title:{Title}, Author:{Author}, ISBN:{ISBN}, Available:{IsAvailable}");
    }
}

