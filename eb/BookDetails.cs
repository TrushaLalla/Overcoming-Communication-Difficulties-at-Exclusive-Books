public class BookDetails
{
    public string Title { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Edition { get; set; }
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsInStock { get; set; } // Checkbox: "Do we have this book in stock?"
    public bool OrderIfNotAvailable { get; set; } // Checkbox: "Would you like us to order it for you?"
    public bool CheckOnline { get; set; } // Checkbox: "onlinecopy ?"
    public bool IsMember { get; set; } // Checkbox: "Are you an Exclusive Books member?"
    public string PreferredFormat { get; set; } // Hardcover, Paperback, eBook
    public string FanaticsNumber { get; set; }

    public BookDetails(string title, string name, string surname, string edition, string description, string phoneNumber,
                       bool isInStock, bool orderIfNotAvailable, bool checkOnline, bool isMember, string preferredFormat,string fanaticsNumber)
    {
        Title = title;
        Name = name;
        Surname = surname;
        Edition = edition;
        Description = description;
        PhoneNumber = phoneNumber;
        IsInStock = isInStock;
        OrderIfNotAvailable = orderIfNotAvailable;
        CheckOnline = checkOnline;
        IsMember = isMember;
        PreferredFormat = preferredFormat;
        FanaticsNumber = fanaticsNumber;
    }
}
