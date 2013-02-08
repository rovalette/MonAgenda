using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntitiesLayer;

namespace DataAcessLayer
{
    public class DalManager : IDAL
    {
        private IDAL _dal = null;

        public IDAL Dal
        {
            get { return _dal; }
            set { _dal = value; }
        }
        private static DalManager _theUniqueInstance;

        private DalManager(DALProvider pro)
        {
            if (pro == DALProvider.SQLSERVER)
                _dal = new DALSQLServer();
        }

        public static DalManager getInstance(DALProvider pro)
        {
            if (_theUniqueInstance == null)
            {
                _theUniqueInstance = new DalManager(pro);
            }

            return _theUniqueInstance;
        }

        public List<Artiste> getAllArtistes()
        {
            return Dal.getAllArtistes();
        }

        public List<PlanningElement> getAllEvenements()
        {
            return Dal.getAllEvenements();
        }

        public List<Lieu> getAllLieux()
        {
            return Dal.getAllLieux();
        }

        public List<PlanningElement> getEvenementsByLieu(String lieu)
        {
            return Dal.getEvenementsByLieu(lieu);
        }

        public Utilisateur getUtilisateurByLogin(string login)
        {
            return Dal.getUtilisateurByLogin(login);
        }

        public void update(IList<PlanningElement> New, IList<PlanningElement> Old)
        {
            Dal.update(New, Old);
        }
    }
}
