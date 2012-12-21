using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    class PlannigElement
    {
        #region Members
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private int _guid;
        private Evenement _monEvenement;
        private Lieu _monLieu;
        private int _nombresPlacesReservees;
        #endregion

        #region Properties
        public int NombresPlacesReservees
        {
            get { return _nombresPlacesReservees; }
            set { _nombresPlacesReservees = value; }
        }

        internal Lieu MonLieu
        {
            get { return _monLieu; }
            set { _monLieu = value; }
        }

        internal Evenement MonEvenement
        {
            get { return _monEvenement; }
            set { _monEvenement = value; }
        }

        public int Guid
        {
            get { return _guid; }
            set { _guid = value; }
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
        public PlannigElement(DateTime inDateDebut, DateTime inDateFin, int inGuid,
            Evenement inMonEvenement, Lieu inMonLieu, int inNbPlacesReservees)
        {
            DateDebut = inDateDebut;
            DateFin = inDateFin;
            Guid = inGuid;
            MonEvenement = inMonEvenement;
            MonLieu = inMonLieu;
            NombresPlacesReservees = inNbPlacesReservees;
        }
        #endregion
    }
}
