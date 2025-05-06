using System.Collections.ObjectModel;
using Project.Models;

namespace Project.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "\"Welcome to Avalonia! This is my added text.";
    public ObservableCollection<Book> Books { get; }

    public MainWindowViewModel()
    {
        Books = new ObservableCollection<Book>
        {
            new Book { Title = "書名1", Author = "作者A" },
            new Book { Title = "書名2", Author = "作者B" },
            new Book { Title = "書名3", Author = "作者C" },
            new Book { Title = "書名4", Author = "作者D" },
            new Book { Title = "書名5", Author = "作者E" },
            new Book { Title = "書名6", Author = "作者F" },
            new Book { Title = "書名7", Author = "作者G" },
            new Book { Title = "書名8", Author = "作者H" },
            new Book { Title = "書名9", Author = "作者I" },
            new Book { Title = "書名10", Author = "作者J" }
        };
    }
}