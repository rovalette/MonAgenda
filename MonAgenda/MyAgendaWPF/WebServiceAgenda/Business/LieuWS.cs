using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceAgenda.Business
{
    [DataContract]
    public class LieuWS
    {
        #region Members
        private String _guid;
        private String _name;
        private String _adress;
        private String _description;
        int _nbPlaces;
        private String _webSite;
        float _locationPercent;
        #endregion

        #region Properties
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

        [DataMember]
        public String Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DataMember]
        public int NbPlaces
        {
            get { return _nbPlaces; }
            set { _nbPlaces = value; }
        }

        [DataMember]
        public String WebSite
        {
            get { return _webSite; }
            set { _webSite = value; }
        }

        [DataMember]
        public float LocationPercent
        {
            get { return _locationPercent; }
            set { _locationPercent = value; }
        }
        #endregion

        #region Methods
        public LieuWS(String inGuid, String inName, String inAdress, String inDescription, int inNbPlaces, String inWebSite, float inLocationPercent)
        {
            _guid = inGuid;
            _name = inName;
            _adress = inAdress;
            _description = inDescription;
            _nbPlaces = inNbPlaces;
            _webSite = inWebSite;
            _locationPercent = inLocationPercent;
        }

        public override String ToString()
        {
            return Name;
        }
        #endregion
    }
}