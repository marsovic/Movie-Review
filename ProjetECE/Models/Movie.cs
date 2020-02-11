using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetECE.Models
{
    public class Movie: INotifyPropertyChanged
    {
        private string id;
        private string title;
        private string releaseDate;
        private string summary;
        private string pic;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (id != value)
                {
                    id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (title != value)
                {
                    title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }

            set
            {
                if (releaseDate != value)
                {
                    releaseDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Summary
        {
            get
            {
                return this.summary;
            }

            set
            {
                if (summary != value)
                {
                    summary = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Pic
        {
            get
            {
                return this.pic;
            }

            set
            {
                if (pic != value)
                {
                    pic = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Movie(
                string id,
                string title,
                string releaseDate,
                string summary,
                string pic
            )
        {
            this.id = id;
            this.title = title;
            this.releaseDate = releaseDate;
            this.summary = summary;
            this.pic = pic;
        }

        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }
    }
}
