using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class Member : Person
{
    public List<Book> BorrowedBooks { get; set; } 
    public Member(string name, int id) : base(name, id)
    {
        BorrowedBooks = new List<Book>();
    }

    // method to borrow book 
    public void BorrowBook(Book book)                           
    {
        if (book.IsAvailable)
        {
            BorrowedBooks.Add(book);
            book.IsAvailable = false;
            Console.WriteLine($"{Name} borrowed the book : {book.Title}");



        }
        else
        {
            Console.WriteLine($"{book.Title} not available");
        }
    }

    // return book
    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            BorrowedBooks.Remove(book);
            book.IsAvailable  =true;
            Console.WriteLine($"{Name} returned the book : {book.Title}");
        }
        else
        {
            Console.WriteLine($"{book.Title} not borrowed");
        }
    }

    // lets implement the abstract class method here 
    public override void DisplayInfo()
    {
        Console.WriteLine($"Member Name : {Name}, MemberID : {Id}");
    }
}