using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    abstract class Evenement
    {
        #region Members
        private List<Artiste> _artistes;
        private String _description;
        private int _guid;
        private float _tarif;
        private String _titre;
        #endregion

        #region properties
        public List<Artiste> Artistes
        {
            get { return _artistes; }
            set { _artistes = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        public float Tarif
        {
            get { return _tarif; }
            set { _tarif = value; }
        }

        public String Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        #endregion

        #region Methods
        public float Calculertarif();
        public Evenement(List<Artiste> inArtiste, String inDescription, int inGuid, float inTarif, String inTitre)
        {
            Artistes = inArtiste;
            Description = inDescription;
            Guid = inGuid;
            Tarif = inTarif;
            Titre = inTitre;
        }

        public String ToString()
        {
            return Titre; 
        }
        #endregion
    }
}
