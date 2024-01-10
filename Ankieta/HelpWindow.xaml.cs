using System.IO;
using System.Windows;



namespace Ankieta;

public partial class HelpWindow : Window
{
    public HelpWindow()
    {
        InitializeComponent();
    }


    private void CloseButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.Hide();

    }
}