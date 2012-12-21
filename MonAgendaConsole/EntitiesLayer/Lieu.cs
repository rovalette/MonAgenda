using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    class Lieu
    {
        #region Members
        private String _adresse;
        private int _codePostal;
        private int _guid;
        private String _nom;
        private int _nbPlacesTotales;
        private String _pays;
        private float _poucentageCommission;
        private String _telephone;
        private String _ville;
        #endregion

        #region Properties
        public String Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public int CodePostal
        {
            get { return _codePostal; }
            set { _codePostal = value; }
        }

        public int Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public int NbPlacesTotales
        {
            get { return _nbPlacesTotales; }
            set { _nbPlacesTotales = value; }
        }

        public String Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }

        public float PoucentageCommission
        {
            get { return _poucentageCommission; }
            set { _poucentageCommission = value; }
        }

        public String Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public String Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inAdresse"></param>
        /// <param name="inCodePostal"></param>
        /// <param name="inGuid"></param>
        /// <param name="inNom"></param>
        /// <param name="inNbPlacesTotales"></param>
        /// <param name="inPays"></param>
        /// <param name="inPourcentageCommission"></param>
        /// <param name="inTelephone"></param>
        /// <param name="inVille"></param>
        public Lieu(String inAdresse, int inCodePostal, int inGuid, String inNom,
            int inNbPlacesTotales, String inPays, float inPourcentageCommission,
            String inTelephone, String inVille)
        {
            Adresse = inAdresse;
            CodePostal = inCodePostal;
            Guid = inGuid;
            Nom = inNom;
            NbPlacesTotales = inNbPlacesTotales;
            Pays = inPays;
            PoucentageCommission = inPourcentageCommission;
            Telephone = inTelephone;
            Ville = inVille;
        }

        public String ToString()
        {
            return Nom + " de " + Ville;
        }
        #endregion
    }
}
