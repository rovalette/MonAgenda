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
    /// Interaction logic for ArtistesViewer.xaml
    /// </summary>
    public partial class ArtistesViewer : Window
    {
        public ArtistesViewer()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // récupération des artistes
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();
            IList<EntitiesLayer.Artiste> artistes = bm.GetArtistes();

            // Initialisation du viewModel

            ViewModel.ArtistesViewModel avm = new WpfArtistesViewer.ViewModel.ArtistesViewModel(artistes);
            avm.CloseNotified += CloseNotified;
            ucArtistes.DataContext = avm;
        }

        private void CloseNotified(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ViewModel.ArtistesViewModel avm = null;

            // On recupère le viewModel et on désinscrit l'event
            avm = (ViewModel.ArtistesViewModel)ucArtistes.DataContext;
            if (avm != null) avm.CloseNotified -= CloseNotified;
        }
    }
}
