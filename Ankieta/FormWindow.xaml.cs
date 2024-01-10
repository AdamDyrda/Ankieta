using System;
using System.IO;
using System.Net;
using System.Windows;


namespace Ankieta;

public partial class FormWindow : Window
{
    public FormWindow()
    {
        InitializeComponent();
    }

    private void ConfirmNameButton_OnClick(object sender, RoutedEventArgs e)
    {
        string Name = FirstNameBox.Text + " " + LastNameBox.Text + "\n";
        if (string.IsNullOrWhiteSpace(Name))
        {
            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show("Name wasn't provided!!");
            return;
        }

        FirstNameBox.Text = string.Empty;
        LastNameBox.Text = string.Empty;
        string path = Directory.GetCurrentDirectory() + "\\names.txt";
        
        if (!File.Exists(path))
        {
            File.Create(path);
            MessageBox.Show("Created new names file! File Directory{0}",path);
        }

        {
            File.AppendAllText(path, Name);
            MessageBox.Show("Your name has been saved!");
            this.Close();
        }
    }
}