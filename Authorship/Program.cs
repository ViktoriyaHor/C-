namespace Authorship;

class Program
{
    static void Main(string[] args)
    {
        Author author1 = new Author("Mark", "Twen");
        Book book1 = new Book("Tom Sawyer");
        Authorship authorship = new Authorship(author1, book1, DateTime.Now);
        authorship.Display();
    }
}

public class Book
{
    public string Title { get; set; }

    public Book(string title){
        Title = title;
    }
}

public class Author {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public Author(string firstName, string lastName){
        FirstName = firstName;
        LastName = lastName;
    }

    public string FullName(){
        return FirstName + " " + LastName;
    }
}

public class Authorship{
    public Author Author { get; set; }
    public Book Book { get; set; }
    public DateTime CreatedAt { get; set; }

    public Authorship(Author author, Book book, DateTime createdAt){
        Author = author;
        Book = book;
        CreatedAt = createdAt;
    }

    public void Display(){
        Console.WriteLine($"Author {Author.FullName()} wrote a book '{Book.Title}' at {CreatedAt.ToShortDateString()}");
    }
}
