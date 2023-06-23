using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Mooder.ViewModels;
using Mooder.Views;
using ReactiveUI;
using System.Reactive.Concurrency;

namespace Mooder;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var model = new PlaylistViewModel();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = model
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new PlayerView
            {
                DataContext = model
            };
        }
        RxApp.MainThreadScheduler.Schedule(model.LoadData);

        base.OnFrameworkInitializationCompleted();
    }
}