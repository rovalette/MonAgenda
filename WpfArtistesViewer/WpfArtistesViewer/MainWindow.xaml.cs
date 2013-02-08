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

namespace WpfArtistesViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnArtisteDirect_Click(object sender, RoutedEventArgs e)
        {
            Forms.ArtisteViewer av = new WpfArtistesViewer.Forms.ArtisteViewer();
            av.ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }

        private void btnArtisteATraversListe_Click(object sender, RoutedEventArgs e)
        {
            Forms.ArtistesViewer av = new WpfArtistesViewer.Forms.ArtistesViewer();
            av.ShowDialog();
        }
    }
}
