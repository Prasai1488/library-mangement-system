using System;
using System.Collections.Generic;


public class Library
{
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Member> Member { get; set; } = new List<Member>();

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to library");
    }

    public void RemoveBook(Book book)
    {
        if (Books.Contains(book))
        {
            Books.Remove(book);
            Console.WriteLine($"{book.Title} removed successfully");
        }
        else
        {
            Console.WriteLine($"{book.Title} not found ");
        }
    }

    public void RegisterMember(Member member)
    {
        Member.Add(member);
        Console.WriteLine($"New member '{member.Name}' added successfully");
    }

    public void ListBooks()
    {
        if (Books.Count == 0)
        {
            Console.WriteLine("No books available");
        }

        else
        {
            foreach (var  book in Books)
            {
                book.DisplayDetails();
            }
        }
    }
}