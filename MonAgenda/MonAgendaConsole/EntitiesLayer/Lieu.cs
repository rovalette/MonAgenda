using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Lieu
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
        public String Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }
        
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public String Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        public int NbPlaces
        {
            get { return _nbPlaces; }
            set { _nbPlaces = value; }
        }
        
        public String WebSite
        {
            get { return _webSite; }
            set { _webSite = value; }
        }

        public float LocationPercent
        {
            get { return _locationPercent; }
            set { _locationPercent = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inGuid"></param>
        /// <param name="inName"></param>
        /// <param name="inAdress"></param>
        /// <param name="inDescription"></param>
        /// <param name="inNbPlaces"></param>
        /// <param name="inWebSite"></param>
        /// <param name="inLocationPercent"></param>
        public Lieu(String inGuid, String inName, String inAdress, String inDescription, int inNbPlaces, String inWebSite, float inLocationPercent)
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
