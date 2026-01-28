public class book
{
    public string author;
    public int releaseYear;
    public int pageCount;
    public string title;
    
    public book(string author, int releaseYear, int pageCount, string title) {
        this.author = author;
        this.releaseYear = releaseYear;
        this.pageCount = pageCount;
        this.title = title;
    }

    public void printInfo()
    {
        Console.WriteLine("Author: " + this.author);
        Console.WriteLine("Release date: " + this.releaseYear);
        Console.WriteLine("Page count: " + this.pageCount);
        Console.WriteLine("Book title: " + this.title);
    }
}
