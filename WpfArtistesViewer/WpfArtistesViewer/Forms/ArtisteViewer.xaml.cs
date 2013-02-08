using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfArtistesViewer.Forms
{
    /// <summary>
    /// Interaction logic for ArtisteViewer.xaml
    /// </summary>
    public partial class ArtisteViewer : Window
    {
        private EntitiesLayer.Artiste _source;

        public ArtisteViewer():this(null){}

        public ArtisteViewer(EntitiesLayer.Artiste source) 
        {
            InitializeComponent();

            if (source == null)
            {
                // récupération d'un artiste
                BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();
                _source = bm.GetArtistes()[0];
            }
            else _source = source;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            // Initialisation du viewModel

            ViewModel.ArtisteViewModel avm = new WpfArtistesViewer.ViewModel.ArtisteViewModel(_source);
            ucArtiste.DataContext = avm;
        }
        
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
