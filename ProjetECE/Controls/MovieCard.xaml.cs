using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System;

namespace ProjetECE.Controls
{
    /// <summary>
    /// Interaction logic for MovieCard.xaml
    /// </summary>
    public partial class MovieCard : UserControl
    {
        public string Id
        {
            get { return (string)GetValue(IdProperty); }
            set { SetValue(IdProperty, value); }
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string ReleaseDate
        {
            get { return (string)GetValue(ReleaseDateProperty); }
            set { SetValue(ReleaseDateProperty, value); }
        }

        public string Resume
        {
            get { return (string)GetValue(ResumeProperty); }
            set { SetValue(ResumeProperty, value); }
        }

        public string Pic
        {
            get { return (string)GetValue(PicProperty); }
            set { SetValue(PicProperty, value); }
        }
      
        public static readonly DependencyProperty IdProperty =
            DependencyProperty.Register("Id", typeof(string), typeof(MovieCard), new PropertyMetadata(""));

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(MovieCard), new PropertyMetadata(""));

        public static readonly DependencyProperty ReleaseDateProperty =
            DependencyProperty.Register("ReleaseDate", typeof(string), typeof(MovieCard), new PropertyMetadata(""));
        

        public static readonly DependencyProperty ResumeProperty =
            DependencyProperty.Register("Resume", typeof(string), typeof(MovieCard), new PropertyMetadata(""));

        public static readonly DependencyProperty PicProperty =
           DependencyProperty.Register("Pic", typeof(string), typeof(MovieCard), new PropertyMetadata(""));



        public delegate void OnCardClickedDelegate(string Id);
        public event OnCardClickedDelegate OnCardClickedEvent;

        public MovieCard()
        {
            InitializeComponent();
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OnCardClickedEvent != null)
            {
                OnCardClickedEvent(Id);
            }
        }
    }
}
