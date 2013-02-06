using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAcessLayer;
using EntitiesLayer;

namespace BusinessLayer
{
    public class BusinessManager
    {
        private static DALProvider _pro = DALProvider.SQLSERVER;
        private static BusinessManager _bus;

        private BusinessManager(DALProvider provider)
        {
            _pro = provider;
        }

        public static bool checkConnection(String login, String pwd)
        {
            return true;
        }

        public static BusinessManager getInstance()
        {
            if (_bus == null)
                _bus = new BusinessManager(_pro);
            return _bus;
        }

        public List<Artiste> getAllArtistes()
        {
            return DalManager.getInstance(_pro).getAllArtistes().OrderBy(a => a.Name).ToList();
        }

        public List<PlanningElement> getAllEvenements()
        {
            return DalManager.getInstance(_pro).getAllEvenements().OrderBy(e => e.DateDebut).ToList();
        }

        public List<Lieu> getAllLieux()
        {
            return DalManager.getInstance(_pro).getAllLieux().OrderBy(l => l.Name).ToList();
        }

        public List<PlanningElement> getEvenementsByLieu(String lieu)
        {
            return DalManager.getInstance(_pro).getEvenementsByLieu(lieu).OrderBy(e => e.DateDebut).ToList();
        }

        public List<Utilisateur> getUtilisateurByLogin(string login)
        {
            return DalManager.getInstance(_pro).getUtilisateurByLogin(login).OrderBy(u => u.Nom).ToList();
        }

        public void update()
        {
            DalManager.getInstance(_pro).update();
        }
    }
}
