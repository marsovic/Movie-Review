using System.Windows.Controls;
using System.Windows.Media;
using System;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjetECE.Controls
{
    /// <summary>
    /// Interaction logic for MovieSearchBox.xaml
    /// </summary>
    public partial class MovieSearchBox : UserControl
    {
        private string searchValue;
        public delegate void SearchBoxChangedHandler(string value);
        public event SearchBoxChangedHandler SearchBoxChangedEvent;

        public MovieSearchBox()
        {
            InitializeComponent();
        }


        private void UpdateSearchValue(string newValue)
        {
            MovieTextBox.Text = searchValue = newValue;
        }

        

        private void MovieTextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (searchValue == "Search a movie...")
            {
                MovieTextBox.Text = searchValue = "";
            }
        }

        private void MovieTextBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (searchValue == "")
            {
                MovieTextBox.Text =  searchValue = "Search a movie...";
            }
        }

        private void MovieTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text != searchValue && SearchBoxChangedEvent != null)
            {
                SearchBoxChangedEvent(textBox.Text);
            }

            UpdateSearchValue(textBox.Text);
        }
    }
}
