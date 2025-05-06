using System.Collections.Generic;
using  CommunityToolkit.Mvvm.ComponentModel;
    
namespace Project.Models;

public class Book
{
    public string Thumbnail { get; set; } = "";
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string ISBN { get; set; } = "";
    public List<string> Tags = new List<string>();
}