using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Project.ViewModels;

namespace Project.Views;

public partial class BookRecordView : Window
{
    public BookRecordView()
    {
        InitializeComponent();
        DataContext = new BookRecordViewModel();
    }
}