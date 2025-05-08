using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using Project.Models;
using Project.ViewModels;

namespace Project.Views;

public partial class BookShelfView : UserControl
{
    public BookShelfView()
    {
        InitializeComponent();
    }

    public void OnBookClick( object? sender , RoutedEventArgs e)
    {
        if (sender is Control control && control.DataContext is Book clickedBook)
        {
            // 往上找 Window
            var window = control.GetVisualRoot() as MainWindow;
            window?.ShowRecord(clickedBook);
        }
    }
}