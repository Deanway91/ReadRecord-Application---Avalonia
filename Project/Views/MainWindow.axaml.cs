using Avalonia.Controls;
using Project.ViewModels;

namespace Project.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}