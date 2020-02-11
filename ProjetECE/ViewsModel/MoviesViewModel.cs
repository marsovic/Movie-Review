using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProjetECE.Models;

namespace ProjetECE.ViewsModel
{
    public class MoviesViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }

        private ObservableCollection<Movie> movies;

        public ObservableCollection<Movie> Movies
        {
            get
            {
                return movies;
            }

            set
            {
                if(movies != value)
                {
                    movies = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public MoviesViewModel()
            {
                Movie movie1 = new Movie(
                        id: "1",
                        title: "Fast And Furious 1",
                        releaseDate: "20 december 2017",
                        summary: "First Movie",
                        pic: "/Resources/Images/fast.jpeg"
                    );

                Movie movie2 = new Movie(
                        id: "2",
                        title: "Fast And Furious 2",
                        releaseDate: "20 december 2018",
                        summary: "Second Movie",
                        pic: "/Resources/Images/fast.jpeg"
                    );

                Movie movie3 = new Movie(
                        id: "3",
                        title: "Fast And Furious 3",
                        releaseDate: "20 december 2019",
                        summary: "Third Movie",
                        pic: "/Resources/Images/fast.jpeg"
                    );

                movies = new ObservableCollection<Movie>();
                movies.Add(movie1);
                movies.Add(movie2);
                movies.Add(movie3);
            }


        public ObservableCollection<Movie> UpdateMovies(string title)
        {
            return movies;
        }
        
    }


        
}
