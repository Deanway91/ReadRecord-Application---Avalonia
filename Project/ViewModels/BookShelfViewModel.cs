using System.Collections.ObjectModel;
using Project.Models;

namespace Project.ViewModels;

public class BookShelfViewModel : ViewModelBase
{
    private readonly BookRepository _bookRepository = new BookRepository();
    public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();
    
    public BookShelfViewModel()
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