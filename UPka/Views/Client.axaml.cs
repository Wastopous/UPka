using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using UPka.ViewModels;

namespace UPka.Views;

public partial class Client : Window
{
    public Client()
    {
        InitializeComponent();
        DataContext = new ClientModel();
    }
}