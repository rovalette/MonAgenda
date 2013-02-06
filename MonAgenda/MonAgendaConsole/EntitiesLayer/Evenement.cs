using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public abstract class Evenement
    {
        #region Members
        private Artiste _artiste;
        private String _description;
        private String _guid;
        private float _tarif;
        private String _titre;
        #endregion

        #region properties
        public Artiste Artistes
        {
            get { return _artiste; }
            set { _artiste = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public String Guid
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
        public abstract float CalculerTarif();
        public Evenement(Artiste inArtiste, String inDescription, String inGuid, float inTarif, String inTitre)
        {
            Artistes = inArtiste;
            Description = inDescription;
            Guid = inGuid;
            Tarif = inTarif;
            Titre = inTitre;
        }

        public override String ToString()
        {
            return Titre; 
        }
        #endregion
    }
}
