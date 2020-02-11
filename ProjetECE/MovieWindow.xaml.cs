using System;
using System.Windows;
using System.Runtime.CompilerServices;
using ProjetECE.Models;
using System.ComponentModel;

namespace ProjetECE
{
    public partial class MovieWindow : Window
    {
        private Movie _movie;
        
        public Movie Movie
        {
            get
            {
                return this._movie;
            }

            set
            {
                if (_movie != value)
                {
                    this._movie = value;
                }
            }

        }

        public MovieWindow(Movie movie)
        {
            InitializeComponent();

            this.DataContext = this;

            this._movie = movie;
            this.Title = movie.Title;
        }
    }
}
