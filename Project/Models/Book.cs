using System.Collections.Generic;
using  CommunityToolkit.Mvvm.ComponentModel;
    
namespace Project.Models;

public class Book
{
    public int id { get; set; } = 0;
    public string Thumbnail { get; set; } = "";
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string ISBN { get; set; } = "";
    public string Tags;

    public Book() {}
    public Book(string Title, string Author = "", string ISBN = "", string thumbnail = "")
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
        this.Thumbnail = thumbnail;
        Tags = "";
    }
}