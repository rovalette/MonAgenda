using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceAgenda.Business
{
    [DataContract]
    public class PlanningElementWS
    {
        #region Members
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private EvenementWS _evenement;
        private LieuWS _lieu;
        private int _nombresPlacesReservees;
        #endregion

        #region Properties
        [DataMember]
        public int NombresPlacesReservees
        {
            get { return _nombresPlacesReservees; }
            set { _nombresPlacesReservees = value; }
        }

        [DataMember]
        public LieuWS Lieu
        {
            get { return _lieu; }
            set { _lieu = value; }
        }

        [DataMember]
        public EvenementWS Evenement
        {
            get { return _evenement; }
            set { _evenement = value; }
        }

        [DataMember]
        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        [DataMember]
        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }
        #endregion

        #region Methods
        public PlanningElementWS(DateTime inDateDebut, DateTime inDateFin, EvenementWS inEvenement, LieuWS inLieu, int inNbPlacesReservees)
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