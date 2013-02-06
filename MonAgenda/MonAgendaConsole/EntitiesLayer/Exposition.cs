using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Exposition : Evenement
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
            return (float)2;
        }

        public Exposition(int inNombreOeuvresExposees, Artiste inArtiste, String inDescription, String inGuid, float inTarif, String inTitre)
            : base(inArtiste, inDescription, inGuid, inTarif, inTitre)
        {
            NombreOeuvresExposees = inNombreOeuvresExposees;
        }

        #endregion
    }
}
