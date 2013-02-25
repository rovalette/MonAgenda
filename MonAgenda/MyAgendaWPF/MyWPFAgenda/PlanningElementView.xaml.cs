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
            EventName.Text = e.Evenement.Titre.ToString();
            if (e.Evenement.Artistes != null)
                Artists.Text = e.Evenement.Artistes.ToString();
            Description.Text = e.Evenement.Description.ToString();
            Salle.Items.Clear();
            foreach (EntitiesLayer.Lieu l in BusinessLayer.BusinessManager.getInstance().getAllLieux())
            {
                Salle.Items.Add(l);
                if (l.Guid.Equals(e.Lieu.Guid))
                    Salle.SelectedItem = l;
            }
            Date.Text = e.DateDebut.ToString();
            Prix.Text = (e.Evenement.Tarif * (1 + e.Lieu.LocationPercent / 100)).ToString();
            Reserved.Text = BusinessLayer.BusinessManager.getInstance().getReservedPlaces(e).ToString();
        }
    }
}
