using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI;
using System.Reflection;
using Windows.UI;

namespace ColorsDemo;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        LoadColors();
    }

    private void LoadColors()
    {
        PropertyInfo[] colorProps = typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static);

        foreach (var prop in colorProps)
        {
            Color color = (Color)prop.GetValue(null, null)!;
            string hex = $"#{color.A:X2}{color.R:X2}{color.G:X2}{color.B:X2}";

            var grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(200) },
                    new ColumnDefinition { Width = new GridLength(150) },
                    new ColumnDefinition { Width = new GridLength(150) }
                },
                Margin = new Thickness(0, 5, 0, 5)
            };

            var nameText = new TextBlock
            {
                Text = prop.Name,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 5, 0)
            };

            var hexText = new TextBlock
            {
                Text = hex,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 5, 0)
            };

            var previewRect = new Border
            {
                Background = new SolidColorBrush(color),
                Width = 80,
                Height = 20,
                CornerRadius = new CornerRadius(3),
                BorderBrush = new SolidColorBrush(Colors.Gray),
                BorderThickness = new Thickness(1),
                Margin = new Thickness(5, 0, 5, 0)
            };

            grid.Children.Add(nameText);
            grid.Children.Add(hexText);
            grid.Children.Add(previewRect);

            Grid.SetColumn(nameText, 0);
            Grid.SetColumn(hexText, 1);
            Grid.SetColumn(previewRect, 2);

            ColorsPanel.Children.Add(grid);
        }
    }
}
