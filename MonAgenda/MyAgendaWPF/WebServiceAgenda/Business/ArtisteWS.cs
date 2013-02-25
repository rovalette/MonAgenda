using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceAgenda.Business
{
    [DataContract]
    public class ArtisteWS
    {
         #region Members
        private DateTime _birthDate;
        private String _guid;
        private String _name;
        #endregion

        #region Properties
        [DataMember]
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        [DataMember]
        public String Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Methods
        public ArtisteWS(String inName, DateTime inBirthDate, String inGuid)
        {
            Name = inName;
            BirthDate = inBirthDate;
            Guid = inGuid;
        }

        public EntitiesLayer.Artiste castToArtiste()
        {
            return new EntitiesLayer.Artiste(_name, BirthDate, Guid);
        }

        public override String ToString()
        {
            return Name;
        }
        #endregion

        internal static ArtisteWS castFromArtiste(EntitiesLayer.Artiste inArtiste)
        {
            return new ArtisteWS(inArtiste.Name, inArtiste.BirthDate, inArtiste.Guid);
        }
    }
}