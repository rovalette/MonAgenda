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
using System.Windows.Shapes;


namespace MyWPFAgenda.ViewModel
{
    /// <summary>
    /// Logique d'interaction pour GestionElementView.xaml
    /// </summary>
    public partial class GestionElementView : Window
    {
        private PlanningElementView pev;

        public GestionElementView()
        {
            InitializeComponent();
            pev = new PlanningElementView();
            Grid.SetColumn(pev, 1);
            Grid.SetRowSpan(pev, 3);
            bigGrid.Children.Add(pev);

            List<EntitiesLayer.PlanningElement> list = BusinessLayer.BusinessManager.getInstance().getAllEvenements();

            foreach (EntitiesLayer.PlanningElement pe in list)
            {
                listBox.Items.Add(pe);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pev.Fill((EntitiesLayer.PlanningElement) listBox.SelectedItem);
        }
    }
}
