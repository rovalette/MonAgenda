using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Utilisateur
    {
        private String _login;
        private String _pwd;
        private String _nom;
        private String _prenom;

        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }


        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public String Pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }

        public String Login
        {
            get { return _login; }
            set { _login = value; }
        }
    }
}
