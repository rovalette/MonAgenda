using System;
using System.Collections.Generic;
using System.IO;
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

namespace MyWPFAgenda
{
    /// <summary>
    /// Logique d'interaction pour login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
            connexion.Click += new RoutedEventHandler(connexion_Click);
            Login.Focus();
        }

        void connexion_Click(object sender, RoutedEventArgs e)
        {
            if (BusinessLayer.BusinessManager.checkConnection(Login.Text.ToLower(), pwd.Password))
            {
                App.Preferences = new Preferences(Login.Text);
                App.Preferences.load();
                new MainWindow().Show();
                this.Close();
            }
            else
            {
                pwd.Password = "";
            }
        }
    }
}
