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

namespace MyWPFAgenda
{
    /// <summary>
    /// Logique d'interaction pour Lieu.xaml
    /// </summary>
    public partial class Lieu : Window
    {
        public Lieu()
        {
            InitializeComponent();

            foreach (EntitiesLayer.Lieu i in BusinessLayer.BusinessManager.getInstance().getAllLieux())
                zoneText.Text += i.ToString() + "\n";
        }
    }
}
