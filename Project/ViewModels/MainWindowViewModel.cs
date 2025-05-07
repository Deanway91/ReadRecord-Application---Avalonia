using System;
using System.Collections.ObjectModel;
using Microsoft.Data.Sqlite;
using Project.Models;

namespace Project.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();
    private BookRepository _bookRepository= new BookRepository();
    
    public MainWindowViewModel()
    {
        _bookRepository.CreateTable();
        
        LoadBook();
    }

    private void LoadBook()
    {
        var booksFromDb = _bookRepository.GetAllBooks();
        Books.Clear();
        foreach (var book in booksFromDb)
            Books.Add(book); // 加入 ObservableCollection 以觸發 UI 更新
    }
}