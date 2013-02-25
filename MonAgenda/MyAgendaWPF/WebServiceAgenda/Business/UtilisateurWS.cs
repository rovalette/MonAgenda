using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceAgenda.Business
{
    [DataContract]
    public class UtilisateurWS
    {
        #region Members
        private String _login;
        private String _pwd;
        private String _nom;
        private String _prenom;
        #endregion

        public UtilisateurWS(String login, String pwd)
        {
            _login = login;
            _pwd = pwd;
        }

        public UtilisateurWS()
        {
            _login = "NOLOGIN";
        }

        [DataMember]
        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        [DataMember]
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        [DataMember]
        public String Pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }

        [DataMember]
        public String Login
        {
            get { return _login; }
            set { _login = value; }
        }
    }
}