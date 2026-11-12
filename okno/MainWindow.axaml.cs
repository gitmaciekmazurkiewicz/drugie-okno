using Avalonia.Controls;
using Avalonia.Interactivity;

namespace okno;

public partial class MainWindow : Window
{
    private int _licznik;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Przycisk_Click(object? sender, RoutedEventArgs e)
    {
        _licznik++;
        this.FindControl<TextBlock>("Podpis")!.Text = $"Kliknięto {_licznik} razy";
    }
}
