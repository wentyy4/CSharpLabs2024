using System;

class Title
{
    private string title;

    public Title(string title)
    {
        this.title = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(title);
        Console.ResetColor();
    }
}

class Author
{
    private string author;

    public Author(string author)
    {
        this.author = author;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(author);
        Console.ResetColor();
    }
}

class Content
{
    private string content;

    public Content(string content)
    {
        this.content = content;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(content);
        Console.ResetColor();
    }
}

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public void AddTitle(Title title)
    {
        this.title = title;
    }

    public void AddAuthor(Author author)
    {
        this.author = author;
    }

    public void AddContent(Content content)
    {
        this.content = content;
    }

    public void Show()
    {
        Console.WriteLine("Title:");
        title.Show();
        Console.WriteLine("Author:");
        author.Show();
        Console.WriteLine("Content:");
        content.Show();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.AddTitle(new Title("Назва книги"));
        book.AddAuthor(new Author("Ім'я автора"));
        book.AddContent(new Content("Зміст книги"));
        book.Show();
    }
}
