using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using ProjetECE.Controls;

namespace ProjetECE
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class MovieWindow : Window
    {
        public MovieCard Movie { get; set; }
        public new string Title { get; set; }

        public MovieWindow(MovieCard movie)
        {
            InitializeComponent();
            this.Movie = movie;
            this.Title = movie.Title;
        }
    }
}