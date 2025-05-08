using System;

namespace Project.Models;

public class BookRecord
{
    public long Id { get; set; }    
    public Book book { get; set; }
    public long BookId { get; set; }
    public DateTime? StartDate { get; set; }  
    public DateTime? EndDate { get; set; } 
    public string Note { get; set; } = "";
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; } 
    public int Rating { get; set; }
    public string Tags { get; set; } = "";
}