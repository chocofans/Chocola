using System.Windows;
namespace Chocola;

public partial class MainWindow:Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Minimize(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void Close(object sender, RoutedEventArgs e)
    {
        Close();
    }
}