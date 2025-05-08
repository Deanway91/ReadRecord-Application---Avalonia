using System.Collections.ObjectModel;
using System.Reactive;
using Project.Models;
using Project.Views;
using ReactiveUI;

namespace Project.ViewModels;

public class BookShelfViewModel : ViewModelBase
{
    private readonly BookRepository _bookRepository = new BookRepository();
    public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();
    
    public ReactiveCommand<Book, Unit> GoToRecordCommand { get; }
    
    public BookShelfViewModel(MainWindow mainWindow)
    {
        _bookRepository.CreateTable();
        
        LoadBook();
        
        GoToRecordCommand = ReactiveCommand.Create<Book>(book =>
        {
            mainWindow.ShowRecord(book);
        });
    }

    
    private void LoadBook()
    {
        var booksFromDb = _bookRepository.GetAllBooks();
        Books.Clear();
        foreach (var book in booksFromDb)
            Books.Add(book); // 加入 ObservableCollection 以觸發 UI 更新
    }
}