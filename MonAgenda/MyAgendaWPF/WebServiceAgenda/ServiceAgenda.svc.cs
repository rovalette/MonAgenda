using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceAgenda
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IServiceAgenda
    {

        public List<Business.ArtisteWS> getAllArtistes()
        {
            List<Business.ArtisteWS> list = new List<Business.ArtisteWS>(); 
            foreach(EntitiesLayer.Artiste a in BusinessLayer.BusinessManager.getInstance().getAllArtistes())
            {
                list.Add(new Business.ArtisteWS(a.Name, a.BirthDate, a.Guid));
            }

            return list;
        }

        public Business.ArtisteWS getArtiste(String Guid)
        {
            List<Business.ArtisteWS> list = new List<Business.ArtisteWS>();
            return getAllArtistes().FirstOrDefault(f => f.Guid == Guid);
        }

        public List<Business.EvenementWS> getEvenementsByArtiste(Business.ArtisteWS Artiste)
        {
            List<Business.EvenementWS> list = new List<Business.EvenementWS>();

            foreach (EntitiesLayer.PlanningElement pe in BusinessLayer.BusinessManager.getInstance().getAllEvenements())
            {
                if (pe.Evenement.Artistes != null && pe.Evenement.Artistes.Guid.Equals(Artiste.Guid))
                    list.Add(Business.EvenementWS.castFromEntitiesEvenements(pe.Evenement));
            }

            return list;
        }


        public List<Business.EvenementWS> getAllEvenements()
        {
            List<Business.EvenementWS> list = new List<Business.EvenementWS>();

            foreach (EntitiesLayer.PlanningElement pe in BusinessLayer.BusinessManager.getInstance().getAllEvenements())
            {
                list.Add(Business.EvenementWS.castFromEntitiesEvenements(pe.Evenement));
            }
            return list;
        }


        public List<Business.LieuWS> getAllLieux()
        {
            List<Business.LieuWS> list = new List<Business.LieuWS>();

            foreach (EntitiesLayer.Lieu l in BusinessLayer.BusinessManager.getInstance().getAllLieux())
            {
                list.Add(new Business.LieuWS(l.Guid, l.Name, l.Adress, l.Description, l.NbPlaces, l.WebSite, l.LocationPercent));
            }
            return list;
        }

        public List<Business.EvenementWS> getEventsByLieux(Business.LieuWS l)
        {
            List<Business.EvenementWS> list = new List<Business.EvenementWS>();

            foreach (EntitiesLayer.PlanningElement e in BusinessLayer.BusinessManager.getInstance().getEvenementsByLieu(l.Name))
            {
                list.Add(Business.EvenementWS.castFromEntitiesEvenements(e.Evenement));
            }

            return list;
        }


        public bool checkUser(string login, string mdp)
        {
            return BusinessLayer.BusinessManager.checkConnection(login, mdp);
        }


        public int nbPlacesDisponible(Business.PlanningElementWS pElements)
        {
            return pElements.NombresPlacesReservees;
        }


        public int ReserverPlace(int nbPlaces, Business.PlanningElementWS pElements)
        {
            if (pElements.NombresPlacesReservees >= nbPlaces)
            {
                pElements.NombresPlacesReservees -= nbPlaces;
                return nbPlaces;
            }
            return 0;
        }


        List<Business.LieuWS> IServiceAgenda.getLieuxEvents(string evenement)
        {
            List<EntitiesLayer.PlanningElement> list = new List<EntitiesLayer.PlanningElement>();
            List<Business.LieuWS> lieux = new List<Business.LieuWS>();
            list = BusinessLayer.BusinessManager.getInstance().getAllEvenements().Where(f => f.Evenement.Guid.Equals(evenement)).ToList();
            foreach (EntitiesLayer.PlanningElement pe in list)
            {
                lieux.Add(new Business.LieuWS(pe.Lieu.Guid, pe.Lieu.Name, pe.Lieu.Adress, pe.Lieu.Description, pe.Lieu.NbPlaces, pe.Lieu.WebSite, pe.Lieu.LocationPercent));
            }
            return lieux;
        }
    }
}
