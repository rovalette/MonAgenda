using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfArtistesViewer.ViewModel
{
    public class ArtisteViewModel:ViewModelBase
    {
        // Model encapsulé dans le ViewModel
        private EntitiesLayer.Artiste _artiste;

        public EntitiesLayer.Artiste Artiste
        {
            get { return _artiste; }
            private set { _artiste = value; }
        }

        public ArtisteViewModel(EntitiesLayer.Artiste artisteModel)
        {
            _artiste = artisteModel;
        }

        #region "Propriétés accessibles, mappables par la View"

        public string FirstName
        {
            get { return _artiste.FirstName; }
            set 
            {
                if (value == _artiste.FirstName) return;
                _artiste.FirstName = value;
                base.OnPropertyChanged("FirstName");
            }
        }

        public string Name
        {
            get { return _artiste.Name; }
            set 
            {
                if (value == _artiste.Name) return;
                _artiste.Name = value;
                base.OnPropertyChanged("Name");
            }
        }

        public DateTime BirthDate
        {
            get { return _artiste.BirthDate; }
            set 
            {
                if (value == _artiste.BirthDate) return;
                _artiste.BirthDate = value;
                base.OnPropertyChanged("BirthDate");
                base.OnPropertyChanged("BirthDateFormat");
            }
        }

        public DateTime DeathDate
        {
            get { return _artiste.DeathDate; }
            set 
            {
                if (value == _artiste.DeathDate) return;
                _artiste.DeathDate = value;
                base.OnPropertyChanged("DeathDate");
                base.OnPropertyChanged("DeathDateFormat");
            }
        }

        public String BirthDateFormat
        {
            get { return _artiste.BirthDate.ToShortDateString(); }
        }

        public String DeathDateFormat
        {
            get { return _artiste.DeathDate.ToShortDateString(); }
        }

        #endregion
          
    }
}
