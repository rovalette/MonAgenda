using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Artiste
    {
        private string _firstNname;
        public string FirstName
        {
            get { return _firstNname; }
            set { _firstNname = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private DateTime _deathDate;
        public DateTime DeathDate
        {
            get { return _deathDate; }
            set { _deathDate = value; }
        }

        public Artiste():this(string.Empty,string.Empty,DateTime.MinValue,DateTime.MinValue) 
        { }

        public Artiste(string firstName, string name, DateTime birthDate, DateTime deathDate)
        {
            _firstNname = firstName;
            _name = name;
            _birthDate = birthDate;
            _deathDate = deathDate;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, o: {2}, +: {3}", 
                                 this.FirstName, 
                                 this.Name,
                                 this.BirthDate.ToShortDateString(),
                                 this.DeathDate.ToShortDateString());
        }
    }
}
