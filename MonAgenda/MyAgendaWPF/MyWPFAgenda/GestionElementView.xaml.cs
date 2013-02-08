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
            pev.EventName.TextChanged += EventName_TextChanged;
            pev.Date.LostFocus += Date_LostFocus;
            pev.Description.TextChanged += Description_TextChanged;
            pev.Salle.SelectionChanged += Salle_SelectionChanged;
            Grid.SetColumn(pev, 1);
            Grid.SetRowSpan(pev, 3);
            bigGrid.Children.Add(pev);

            List<EntitiesLayer.PlanningElement> list = BusinessLayer.BusinessManager.getInstance().getAllEvenements();

            foreach (EntitiesLayer.PlanningElement pe in list)
            {
                listBox.Items.Add(pe);
            }
        }

        void Date_LostFocus(object sender, RoutedEventArgs e)
        {
            String[] split = pev.Date.Text.Split(new Char[] { '/', ' ', ':' });
            try
            {
                int day = int.Parse(split[0]);
                int month = int.Parse(split[1]);
                int year = int.Parse(split[2]);
                int hour = int.Parse(split[3]);
                int min = int.Parse(split[4]);
                int sec = int.Parse(split[5]);
                DateTime time = new DateTime(year, month, day, hour, min, sec);
                ((EntitiesLayer.PlanningElement)listBox.SelectedItem).DateDebut = time;
                listBox.Items.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Bad time format!");
            }
        }

        void Salle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (pev.Salle.SelectedItem != null)
            {
                float percentage = (float)((EntitiesLayer.Lieu)pev.Salle.SelectedItem).LocationPercent;
                float initialPrice = (float)((EntitiesLayer.PlanningElement)listBox.SelectedItem).Evenement.Tarif;
                pev.Prix.Text = (initialPrice * (1 + percentage / 100)).ToString();
            }
        }

        void Description_TextChanged(object sender, TextChangedEventArgs e)
        {
            ((EntitiesLayer.PlanningElement)listBox.SelectedItem).Evenement.Description = ((TextBox)sender).Text;
            listBox.Items.Refresh();
        }

        void EventName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ((EntitiesLayer.PlanningElement)listBox.SelectedItem).Evenement.Titre = ((TextBox)sender).Text;
            listBox.Items.Refresh();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
                pev.Fill((EntitiesLayer.PlanningElement) listBox.SelectedItem);
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IList<EntitiesLayer.PlanningElement> list = new List<EntitiesLayer.PlanningElement>();

            for (int i = 0; i < listBox.Items.Count; ++i)
            {
                list.Add((EntitiesLayer.PlanningElement)listBox.Items[i]);
            }

            BusinessLayer.BusinessManager.getInstance().update(list);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not implemented... sorry");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex > -1)
            {

                // suppression
                pev.Artists.Clear();
                pev.Salle.Items.Clear();
                pev.EventName.Clear();
                pev.Date.Clear();
                pev.Description.Clear();
                pev.Prix.Clear();
                pev.Reserved.Clear();
                int index = listBox.SelectedIndex;
                if (listBox.Items.Count != 0)
                {
                    if (index == 0 && listBox.Items.Count != 1)
                        listBox.SelectedItem = listBox.Items[1];
                    else
                        listBox.SelectedItem = listBox.Items[0];
                }
                else
                    listBox.SelectedItem = null;

                listBox.Items.RemoveAt(index);
                listBox.Items.Refresh();
            }
        }


    }
}
