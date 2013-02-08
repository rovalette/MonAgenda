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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWPFAgenda
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            BEvent.Click  += new RoutedEventHandler(BEvent_Click);
            BLieu.Click   += new RoutedEventHandler(BLieu_Click);
            BEPLieu.Click += new RoutedEventHandler(BEPLieu_Click);
            BArtist.Click += new RoutedEventHandler(BArtist_Click);

            if (App.Preferences.Loaded == true)
            {
                this.Width = App.Preferences.Largeur;
                this.Height = App.Preferences.Hauteur;
                this.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;
                this.Left = App.Preferences.Start.X;
                this.Top = App.Preferences.Start.Y;
            }
        }



        void BEvent_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            new Evenement().ShowDialog();
            Cursor = Cursors.Arrow;
        }

        void BLieu_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            new Lieu().ShowDialog();
            Cursor = Cursors.Arrow;
        }

        void BEPLieu_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            new EPLieu().ShowDialog();
            Cursor = Cursors.Arrow;
        }

        void BArtist_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            new Artiste().ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            App.Preferences.Hauteur = this.Height;
            App.Preferences.Largeur = this.Width;
            App.Preferences.Start = new Point(this.Left, this.Top);
        }

        private void ModEv_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            new MyWPFAgenda.ViewModel.GestionElementView().ShowDialog();
            Cursor = Cursors.Arrow;
        }
    }
}
