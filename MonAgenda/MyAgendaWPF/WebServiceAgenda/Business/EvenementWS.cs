using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

using EntitiesLayer;

namespace WebServiceAgenda.Business
{
    [DataContract]
    public class EvenementWS
    {
        #region Members
        private bool _dispositionParticuliere;
        private int _dureeEnMinutes;
        private int _nombreLoges;
        private int _nombreOeuvresExposees;
        private ArtisteWS _artiste;
        private String _description;
        private String _guid;
        private float _tarif;
        private String _titre;
        private bool _concert;

        #endregion

        #region Properties
        [DataMember]
        public int NombreLoges
        {
            get { return _nombreLoges; }
            set { _nombreLoges = value; }
        }

        [DataMember]
        public bool Concert
        {
            get { return _concert; }
            set { _concert = value; }
        }

        [DataMember]
        public int DureeEnMinutes
        {
            get { return _dureeEnMinutes; }
            set { _dureeEnMinutes = value; }
        }

        [DataMember]
        public bool DispositionParticuliere
        {
            get { return _dispositionParticuliere; }
            set { _dispositionParticuliere = value; }
        }
      
        [DataMember]
        public int NombreOeuvresExposees
        {
            get { return _nombreOeuvresExposees; }
            set { _nombreOeuvresExposees = value; }
        }

        [DataMember]
        public ArtisteWS Artistes
        {
            get { return _artiste; }
            set { _artiste = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DataMember]
        public String Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        [DataMember]
        public float Tarif
        {
            get { return _tarif; }
            set { _tarif = value; }
        }

        [DataMember]
        public String Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        #endregion

        #region methods

        //constucteur d'une exposition
        public EvenementWS(int inNombreOeuvresExposees, ArtisteWS inArtiste, String inDescription, String inGuid, float inTarif, String inTitre)
        {
            Concert = false;
            Artistes = inArtiste;
            Description = inDescription;
            Guid = inGuid;
            Tarif = inTarif;
            NombreOeuvresExposees = inNombreOeuvresExposees;
        }

        // constructeur d'un concert
        public EvenementWS(Artiste inArtiste, String inDescription, String inGuid, float inTarif, String inTitre, bool inDispositionParticuliere, int inDureeEnMinutes, int inNombreLoges)
        {
            Concert = true;
            Artistes = ArtisteWS.castFromArtiste(inArtiste);
            Description = inDescription;
            Guid = inGuid;
            Tarif = inTarif;
            DispositionParticuliere = inDispositionParticuliere;
            DureeEnMinutes = inDureeEnMinutes;
            NombreLoges = inNombreLoges;
            DispositionParticuliere = inDispositionParticuliere;
            DureeEnMinutes = inDureeEnMinutes;
            NombreLoges = inNombreLoges;
        }

        public override string ToString()
        {
            String retour;
            if (Concert)
                retour = "Concert : ";
            else
                retour = "Exposition : ";

            retour += Titre;
            return retour;
        }

        public EntitiesLayer.Evenement castToEntitiesEvent()
        {
            EntitiesLayer.Evenement ev;
            if (Concert)
                ev = new EntitiesLayer.Concert(Artistes.castToArtiste(), Description, Guid, Tarif, Titre, DispositionParticuliere, DureeEnMinutes, NombreLoges);
            else
                ev = new EntitiesLayer.Exposition(NombreOeuvresExposees, Artistes.castToArtiste(), Description, Guid, Tarif, Titre);

            return ev;
        }

        public static EvenementWS castFromEntitiesEvenements(EntitiesLayer.Evenement e)
        {
            EvenementWS ev;
            if (e is EntitiesLayer.Concert)
            {
                EntitiesLayer.Concert c = (EntitiesLayer.Concert)e;
                ev = new EvenementWS(c.Artistes, c.Description, c.Guid, c.Tarif, c.Titre, c.DispositionParticuliere, c.DureeEnMinutes, c.NombreLoges);
            }
            else
            {
                EntitiesLayer.Exposition ex = (EntitiesLayer.Exposition)e;
                ev = new EvenementWS(ex.NombreOeuvresExposees, ArtisteWS.castFromArtiste(ex.Artistes), ex.Description, ex.Guid, ex.Tarif, ex.Titre);
            }

            return ev;
        }
        #endregion
    }
}