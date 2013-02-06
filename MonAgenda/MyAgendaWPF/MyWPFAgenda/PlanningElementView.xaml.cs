using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWPFAgenda.ViewModel
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class PlanningElementView : UserControl
    {
        public PlanningElementView()
        {
            InitializeComponent();
        }

        public void Fill(EntitiesLayer.PlanningElement e)
        {
            EventName.Text="{Binding EventName, Source={EventName}, Mode=twoWays}" + e.Evenement.Titre.ToString();
            Artists.Text = e.Evenement.Artistes.ToString();
            Description.Text = e.Evenement.Description.ToString();
            foreach (EntitiesLayer.Lieu l in BusinessLayer.BusinessManager.getInstance().getAllLieux())
            {
                Salle.Items.Add(l.Name.ToString());
                if (l.Guid.Equals(e.Lieu.Guid))
                    Salle.SelectedItem = e.Lieu.Name.ToString();
            }
            Date.Text = e.DateDebut.ToString();
            Prix.Text = e.Evenement.Tarif.ToString();
            Reserved.Text = e.NombresPlacesReservees.ToString();
        }
    }
}
