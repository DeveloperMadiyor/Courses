namespace Bookclass;

public class Book
{
    public string BookName { get; set; }
    public string Author { get; set; }
    private int _Price { get; set; }

    public int Price
    {
        get { return _Price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            _Price = value;
        }
    }
    public Book(string bookName, string author, int price)
    {
        BookName = bookName;
        Author = author;
        Price = price;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Book: {BookName}, Author: {Author}, Price: {Price}");
    }
}
