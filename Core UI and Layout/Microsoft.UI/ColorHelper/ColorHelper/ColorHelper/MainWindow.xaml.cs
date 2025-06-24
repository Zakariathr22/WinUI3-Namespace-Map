using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

namespace ColorHelper;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var myColor = Microsoft.UI.ColorHelper.FromArgb(255, 255, 165, 0); // Gold color
        var brush = new SolidColorBrush(myColor);
        myButton.Background = brush;

        string colorName = Microsoft.UI.ColorHelper.ToDisplayName(myColor); // Usually returns "Gold"
        myTextBlock.Text = $"Color: {colorName}";
    }
}
