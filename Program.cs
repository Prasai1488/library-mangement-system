using System;

class Program
{
    static void Main(string[] args)
    {
        var library = new Library();

        // adding some books to library 
        var book1 = new Book("The legend", "Prithvi Prasai", "1234");
        var book2 = new Book("Lion King", "John", "2222");
        var book3 = new Book("Super Hero", "Ram thapa", "9921");

        // create a new staff :
        var staff1 = new Staff("Bob doe", 1);


        // add book to library
        staff1.AddBookToLibrary(library, book1);
        staff1.AddBookToLibrary(library, book2);

        // Register members
        var member1 = new Member("Prithvi", 09);
        var member2 = new Member("Hari Thapa", 02);
        library.RegisterMember(member1 );

        //display library info
        library.ListBooks();

        // borrow books :
        member1.BorrowBook(book2);

        library.ListBooks();

        // return book
        member1.ReturnBook(book2);

        library.ListBooks();
       
    }
}