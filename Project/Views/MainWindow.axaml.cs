using Avalonia.Controls;
using Project.Models;
using Project.ViewModels;

namespace Project.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
        
        ShowBookshelf();
    }
    
    public void ShowBookshelf()
    {
        var vm = new BookShelfViewModel(this);
        var view = new BookShelfView { DataContext = vm };
        MainContent.Content = view;
    }

    public void ShowRecord(Book book)
    {
        var vm = new BookRecordViewModel(this, book);
        var view = new BookRecordView { DataContext = vm };
        MainContent.Content = view;
    }
}