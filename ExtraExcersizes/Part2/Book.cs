using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtraExcersizes;

    public class Book
{
    //Fields
    private string title;
    private string author;
    private decimal price;

    //Propertys
    public string Title
    {
        get { return title; }
        private set
        {
            if (value.Length < 3)
                throw new ArgumentException("Title is not valid!");
            title = value;
        }
    }
    public string Author
    {
        get { return author; }
        private set
        {
            /*for(int i = 0; i < 10; i++)
                if (value.Contains($" {i}"))
                    throw new ArgumentException("Author not valid!");*/
            Regex re = new Regex(@"([A-Za-z])+ ([\d]+[A-Za-z]*)");
            if (re.IsMatch(value))
                throw new ArgumentException("Author not valid!");
            author = value;
        }
    }
    public virtual decimal Price
    {
        get { return price; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Price not valid!");
            decimal.Round(value, 2, MidpointRounding.AwayFromZero);
            price = value;
        }
    }

    //Constructor
    public Book(string author, string title, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    //Methods
    public override string ToString()
    {
        return $"Type: {this.GetType().Name}\nTitle: {Title}\nAuthor: {Author}\nPrice: {Price.ToString("0.00")}";
    }
}

