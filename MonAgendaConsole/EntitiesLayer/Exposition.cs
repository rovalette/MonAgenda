using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    class Exposition : Evenement
    {
        #region Members
        private int _nombreOeuvresExposees;
        #endregion

        #region Properties
        public int NombreOeuvresExposees
        {
            get { return _nombreOeuvresExposees; }
            set { _nombreOeuvresExposees = value; }
        }
        #endregion

        #region Methods
        public override float CalculerTarif()
        {
            return 2;
        }

        public Exposition(int inNombreOeuvresExposees, List<Artiste> inArtiste, String inDescription, int inGuid, float inTarif, String inTitre)
            : base(inArtiste, inDescription, inGuid, inTarif, inTitre)
        {
            NombreOeuvresExposees = inNombreOeuvresExposees;
        }

        #endregion
    }
}
