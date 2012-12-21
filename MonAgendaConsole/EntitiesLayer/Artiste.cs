using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Artiste
    {
        #region Members
        private DateTime _dateDeNaissance;
        private int _guid;
        private String _nom;
        private String _prenom;
        #endregion

        #region Properties
        public DateTime DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set { _dateDeNaissance = value; }
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

        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        #endregion

        #region Methods
        public Artiste(String inNom, String inPrenom, DateTime inDateNaissance, int inGuid)
        {
            Nom = inNom;
            Prenom = inPrenom;
            DateDeNaissance = inDateNaissance;
            Guid = inGuid;
        }

        public String ToString()
        {
            return Prenom + " " + Nom;
        }
        #endregion
    }
}
