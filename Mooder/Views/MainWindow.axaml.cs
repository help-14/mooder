using Avalonia.Controls;
using Avalonia.Interactivity;
using Mooder.DataSources;
using Mooder.ViewModels;
using System;
using System.Diagnostics;

namespace Mooder.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Loaded += OnLoaded;
    }

    private async void OnLoaded(object? sender, RoutedEventArgs e)
    {
        
    }
}