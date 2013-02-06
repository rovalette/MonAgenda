using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class PlanningElement
    {
        #region Members
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private Evenement _evenement;
        private Lieu _lieu;
        private int _nombresPlacesReservees;
        #endregion

        #region Properties
        public int NombresPlacesReservees
        {
            get { return _nombresPlacesReservees; }
            set { _nombresPlacesReservees = value; }
        }

        public Lieu Lieu
        {
            get { return _lieu; }
            set { _lieu = value; }
        }

        public Evenement Evenement
        {
            get { return _evenement; }
            set { _evenement = value; }
        }

        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }
        #endregion

        #region Methods
        public PlanningElement(DateTime inDateDebut, DateTime inDateFin, Evenement inEvenement, Lieu inLieu, int inNbPlacesReservees)
        {
            DateDebut = inDateDebut;
            DateFin = inDateFin;
            Evenement = inEvenement;
            Lieu = inLieu;
            NombresPlacesReservees = inNbPlacesReservees;
        }

        public override String ToString()
        {
            return Evenement.ToString();
        }
        #endregion
    }
}
