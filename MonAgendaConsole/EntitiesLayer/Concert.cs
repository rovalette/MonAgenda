using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    class Concert : Evenement
    {
        #region Members
        private bool _dispositionParticuliere;
        private int _dureeEnMinutes;
        private int _nombreLoges;
        #endregion

        #region Properties
        public int NombreLoges
        {
            get { return _nombreLoges; }
            set { _nombreLoges = value; }
        }

        public int DureeEnMinutes
        {
            get { return _dureeEnMinutes; }
            set { _dureeEnMinutes = value; }
        }

        public bool DispositionParticuliere
        {
            get { return _dispositionParticuliere; }
            set { _dispositionParticuliere = value; }
        }
        #endregion

        #region Methods
        public override float CalculerTarif() 
        {
            return 2;
        }

        public Concert(List<Artiste> inArtiste, String inDescription, int inGuid, float inTarif, String inTitre, bool inDispositionParticuliere, int inDureeEnMinutes, int inNombreLoges)
            : base(inArtiste, inDescription, inGuid, inTarif, inTitre)
        {
            
            DispositionParticuliere = inDispositionParticuliere;
            DureeEnMinutes = inDureeEnMinutes;
            NombreLoges = inNombreLoges;
        }
        #endregion
    }
}
