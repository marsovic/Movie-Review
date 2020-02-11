using ProjetECE.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using ProjetECE.ViewsModel;
using System.Collections.ObjectModel;
using ProjetECE.Models;

namespace ProjetECE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MovieSpinner movieSpinner;
        private AppLogo appLogo;
        private WrapPanel movieCardsPanel;

        public MainWindow()
        {
            InitializeComponent();

            this.ResizeMode = ResizeMode.NoResize;

            // Defining all the events
            searchBox.SearchBoxChangedEvent += OnSearchBoxChange;

            configuringElements();

            AddElementIntoDockPanel(appLogo);
        }

        private void configuringElements()
        {
            movieSpinner = new MovieSpinner();
            movieSpinner.VerticalAlignment = VerticalAlignment.Center;

            appLogo = new AppLogo();
            appLogo.VerticalAlignment = VerticalAlignment.Center;

            movieCardsPanel = new WrapPanel();
            movieCardsPanel.Margin = new Thickness(50, 40, 50, 20);
            movieCardsPanel.HorizontalAlignment = HorizontalAlignment.Center;
        }

        private void OnSearchBoxChange(string newValue)
        {
            // We verify if the research is an empty research
            if (newValue == "")
            {
                RemoveDockPanelElement();
                AddElementIntoDockPanel(appLogo);

                return;
            }

            // Otherwise we start the research
            RemoveDockPanelElement();
            AddElementIntoDockPanel(movieSpinner);

            // Now we retrieve the new Data
            MoviesViewModel dataContext = (MoviesViewModel)this.DataContext;

            UpdateMovieCards(dataContext.UpdateMovies(title: "Test de la fonction"));
        }

        private void RemoveDockPanelElement()
        {
            UIElementCollection children = dockPanel.Children;

            children.RemoveAt(children.Count - 1);
        }

        private void AddElementIntoDockPanel(UIElement element)
        {
            UIElementCollection children = dockPanel.Children;

            children.Add(element);
        }

        private void UpdateMovieCards(ObservableCollection<Movie> movies)
        {
            movieCardsPanel.Children.Clear();

            foreach(Movie movie in movies)
            {
                MovieCard movieCard = new MovieCard();

                movieCard.Id = movie.Id;
                movieCard.Title = movie.Title;
                movieCard.ReleaseDate = movie.ReleaseDate;
                movieCard.Resume = movie.Summary;
                movieCard.Pic = movie.Pic;
                movieCard.OnCardClickedEvent += MovieCard_OnCardClickedEvent;

                movieCardsPanel.Children.Add(movieCard);
            }
           
            RemoveDockPanelElement();
            AddElementIntoDockPanel(movieCardsPanel);
        }

        private void MovieCard_OnCardClickedEvent(string id)
        {
            Movie movie = new Movie(
                    id: "123456",
                    title: "Hugo a la rescousse",
                    releaseDate: "13/02/2020",
                    summary: "Un jeune dev se voit confie la tache d'aiser son ami",
                    pic: null
                );


            MovieWindow movieWindow = new MovieWindow(movie);

            movieWindow.Show();
        }
    }
}
