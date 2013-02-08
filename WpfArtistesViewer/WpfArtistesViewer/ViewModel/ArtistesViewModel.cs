﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace WpfArtistesViewer.ViewModel
{
    class ArtistesViewModel : ViewModelBase
    {
        // Event destiné à réclamer la fermeture du conteneur;
        public event EventHandler<EventArgs> CloseNotified;
        protected void OnCloseNotified(EventArgs e)
        {
            this.CloseNotified(this, e);
        }

        // Model encapsulé dans le ViewModel
        private ObservableCollection<ArtisteViewModel> _artistes;

        public ObservableCollection<ArtisteViewModel> Artistes
        {
            get { return _artistes; }
            private set 
            { 
                _artistes = value;
                OnPropertyChanged("Artistes");
            }
        }

        private ArtisteViewModel _selectedItem;
        public ArtisteViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }
     
        public ArtistesViewModel(IList<EntitiesLayer.Artiste> artistesModel) 
        {
            _artistes = new ObservableCollection<ArtisteViewModel>();
            foreach (EntitiesLayer.Artiste a in artistesModel) 
            {
                _artistes.Add(new ArtisteViewModel(a)); 
            }
        }

        #region "Commandes du formulaire"

        // Commande Add
        private RelayCommand _addCommand;
        public System.Windows.Input.ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(
                        () => this.Add(),
                        () => this.CanAdd()
                        );
                }
                return _addCommand;
            }
        }

        private bool CanAdd()
        {
            return true;
        }

        private void Add() 
        {
            EntitiesLayer.Artiste a = new EntitiesLayer.Artiste("<New>",
                                                                "<New>", 
                                                                new DateTime(1901, 01, 01),
                                                                new DateTime(1901, 01, 01));
   
            this.SelectedItem = new ArtisteViewModel(a);
            Artistes.Add(this.SelectedItem);
        }

        // Commande Remove
        private RelayCommand _removeCommand;
        public System.Windows.Input.ICommand RemoveCommand
        {
            get
            {
                if (_removeCommand == null)
                {
                    _removeCommand = new RelayCommand(
                        () => this.Remove(),
                        () => this.CanRemove()
                        );
                }
                return _removeCommand;
            }
        }

        private bool CanRemove() 
        {
            return (this.SelectedItem != null);
        }

        private void Remove()
        {
            if (this.SelectedItem != null) Artistes.Remove(this.SelectedItem);
        }

        // Commande Close
        private RelayCommand _closeCommand;
        public System.Windows.Input.ICommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(
                        () => this.Close(),
                        () => this.CanClose()
                        );
                }
                return _closeCommand;
            }
        }

        private bool CanClose()
        {
            return true;
        }

        private void Close()
        {
            OnCloseNotified(new EventArgs());
        }

        #endregion
    }
}
