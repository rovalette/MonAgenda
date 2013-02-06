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
    /// Logique d'interaction pour EPLieu.xaml
    /// </summary>
    public partial class EPLieu : Window
    {
        public EPLieu()
        {
            InitializeComponent();
            foreach (EntitiesLayer.Lieu i in BusinessLayer.BusinessManager.getInstance().getAllLieux())
            {
                combo.Items.Add(i.ToString());
            }
        }

        private void changeIndex(object sender, SelectionChangedEventArgs e)
        {
            if (1==1)
            {
                zoneText.Text = "";
                foreach (EntitiesLayer.PlanningElement i in BusinessLayer.BusinessManager.getInstance().getEvenementsByLieu(combo.SelectedValue.ToString().Replace("'", "''")))
                {
                    zoneText.Text += i.ToString() + "\n";
                }
            }
        }
    }
}
