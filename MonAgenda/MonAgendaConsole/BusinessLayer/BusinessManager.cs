using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
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

        private static String getHashData(String data)
        {
            SHA1 sha1 = SHA1.Create();

            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashData.Length; ++i)
            {
                returnValue.Append(hashData[i].ToString());
            }

            return returnValue.ToString();
        }

        public static bool checkConnection(String login, String pwd)
        {
            Utilisateur user = DalManager.getInstance(_pro).getUtilisateurByLogin(login);
            bool retour;

            if (!user.Login.Equals("NOLOGIN"))
            {
                String toCheck = getHashData(pwd);
                retour = (user.Pwd.Equals(toCheck));
            }
            else
                retour = false;

            return retour;
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

        public void update(IList<PlanningElement> list)
        {
            list = list.OrderBy(d => d.Evenement.Guid).ToList();
            DalManager.getInstance(_pro).update(list, getAllEvenements());
        }
    }
}
