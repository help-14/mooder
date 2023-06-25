using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace Mooder.Views;

public partial class PlaylistView : UserControl
{
    public PlaylistView()
    {
        AvaloniaXamlLoader.Load(this);

        var mainTab = this.FindControl<TabControl>("MainTab");
        if (mainTab != null && (OperatingSystem.IsMacOS() || OperatingSystem.IsLinux()))
        {
            mainTab.Classes.Add("RightHeader");
        }
    }

    //protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    //{
    //}
}