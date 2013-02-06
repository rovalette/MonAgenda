using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Artiste
    {
        #region Members
        private DateTime _birthDate;
        private String _guid;
        private String _name;
        #endregion

        #region Properties
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

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
        #endregion

        #region Methods
        public Artiste(String inName, DateTime inBirthDate, String inGuid)
        {
            Name = inName;
            BirthDate = inBirthDate;
            Guid = inGuid;
        }

        public override String ToString()
        {
            return Name;
        }
        #endregion
    }
}
