using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Mooder.Views;

public partial class PlayerView : UserControl
{
    public PlayerView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}