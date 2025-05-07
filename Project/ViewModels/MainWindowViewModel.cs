using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Data.Sqlite;
using Project.Models;

namespace Project.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentPage;
    
    private readonly BookRecordViewModel _bookRecordPage = new();
    private readonly BookShelfViewModel _bookShelfPage = new();
    
    public MainWindowViewModel()
    {
        CurrentPage = _bookShelfPage;
    }
}