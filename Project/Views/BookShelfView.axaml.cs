using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Project.ViewModels;

namespace Project.Views;

public partial class BookShelfView : UserControl
{
    public BookShelfView()
    {
        InitializeComponent();
        DataContext = new BookShelfViewModel();
    }
}