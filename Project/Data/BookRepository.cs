using System;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using Project.Models;

public class BookRepository
{
    private const string ConnectionString = "Data Source=books.db";
        
    public void CreateTable()
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();
    
        var command = connection.CreateCommand();
        command.CommandText =
            @"
        CREATE TABLE IF NOT EXISTS Books (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Thumbnail TEXT,
            Title TEXT,
            Author TEXT,
            ISBN TEXT,
            Tags TEXT
        )";
        command.ExecuteNonQuery();
    }
    
    public IEnumerable<Book> GetAllBooks()
    {
        using var connection = new SqliteConnection(ConnectionString);
        return connection.Query<Book>("SELECT * FROM Books");
    }

    public void AddBook(Book book)
    {
        using var connection = new SqliteConnection(ConnectionString);
        string sql = @"INSERT INTO Books (Thumbnail, Title, Author, ISBN, Tags)
                       VALUES (@Thumbnail, @Title, @Author, @ISBN, @Tags)";
        Console.WriteLine(book.Author + " " + book.Title);
        connection.Execute(sql, new {
            Thumbnail = book.Thumbnail,
            Title = book.Title,
            Author = book.Author,
            ISBN = book.ISBN,
            Tags = string.Join(",", book.Tags)
            });;
    }
    public void DeleteBook(int id)
    {
        using var conn = new SqliteConnection(ConnectionString);
        conn.Execute("DELETE FROM Books WHERE Id = @Id", new { Id = id });
    }

    public void UpdateBook(Book book)
    {
        using var conn = new SqliteConnection(ConnectionString);
        string sql = @"UPDATE Books 
                   SET Thumbnail = @Thumbnail, Title = @Title, Author = @Author, ISBN = @ISBN, Tags = @Tags 
                   WHERE Id = @Id";
        conn.Execute(sql, book);
    }

}