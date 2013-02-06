using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml.Serialization;

namespace MyWPFAgenda
{
    [Serializable]
    public class Preferences
    {
        private string _login;
        private double _largeur;
        private double _hauteur;
        private Point _start;
        private bool _loaded;

        public Preferences(String login)
        {
            if (login.Equals(""))
                login = "default";
            _login = login;
            _loaded = false;
        }

        public Preferences()
        { }

        public Point Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public bool Loaded
        {
            get { return _loaded; }
            set { _loaded = value; }
        } 

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public double Hauteur
        {
            get { return _hauteur; }
            set { _hauteur = value; }
        }

        public void save()
        {
            StreamWriter stream = new StreamWriter(@".\" + _login + ".xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Preferences));
            serializer.Serialize(stream, this);
            stream.Close(); 
        }

        public void load()
        {
            if (File.Exists(@".\" + _login + ".xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Preferences));
                StreamReader stream = new StreamReader(@".\" + _login + ".xml");
                Preferences pref = (Preferences)deserializer.Deserialize(stream);
                this.Hauteur = pref.Hauteur;
                this.Largeur = pref.Largeur;
                this.Start = pref.Start;
                this.Loaded = true;
                stream.Close();
            }
        }
    }
}
