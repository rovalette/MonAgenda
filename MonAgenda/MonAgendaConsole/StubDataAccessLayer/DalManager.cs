using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        //public List<Artiste> _artistes;
        //public List<Evenement> _evenements;
        //public List<Lieu> _lieux;
        //public List<PlanningElement> _plannings;

        //public DalManager()
        //{
        //    _artistes = new List<Artiste>();

        //    _artistes.Add(new Artiste("Guetta", "David", new DateTime(1975, 2, 22), 0));
        //    _artistes.Add(new Artiste("Berg", "Tim", new DateTime(1982, 5, 1), 0));
        //    _artistes.Add(new Artiste("Van Doorn", "Sander", new DateTime(1980, 11, 30), 0));
        //    _artistes.Add(new Artiste("Berger", "Michel", new DateTime(1960, 1, 15), 0));
        //    _artistes.Add(new Artiste("Halliday", "Jhonny", new DateTime(1953, 7, 27), 0));

        //    _lieux = new List<Lieu>();

        //    //_lieux.Add(new Lieu("la rue a coté du métro", 75000, 0, "Paris Bercy", 10000, "France", 20, "0153403020", "Paris"));
        //    //_lieux.Add(new Lieu("rue du Zénith", 63250, 0, "Zénith", 5000, "France", 10, "0473000000", "Cournon"));
        //    //_lieux.Add(new Lieu("la plage", 17000, 0, "La grande scene", 1000, "France", 1, "0836696969", "La Rochelle"));

        //    _evenements = new List<Evenement>();

        //    List<Artiste> _artistesParis = new List<Artiste>();
        //    _artistesParis.Add(_artistes[0]);
        //    _artistesParis.Add(_artistes[1]);
        //    _artistesParis.Add(_artistes[2]);

        //    _evenements.Add(new Concert(_artistesParis, "Nuits Electro", 0, 100, "Nuits Electro", false, 120, 20));

        //    List<Artiste> _artistesCournon = new List<Artiste>();
        //    _artistesCournon.Add(_artistes[3]);
        //    _artistesCournon.Add(_artistes[4]);

        //    _evenements.Add(new Concert(_artistesCournon, "concert", 0, 100, "Concert nul", false, 240, 5));

        //    List<Artiste> _artistesRochelle = new List<Artiste>();
        //    _artistesRochelle.Add(_artistes[0]);
        //    _artistesRochelle.Add(_artistes[1]);
        //    _artistesRochelle.Add(_artistes[2]);
        //    _artistesRochelle.Add(_artistes[3]);
        //    _artistesRochelle.Add(_artistes[4]);

        //    _evenements.Add(new Exposition(2000, _artistesCournon, "les artistes", 0, 15, "expo!"));

        //    _plannings = new List<PlanningElement>();

        //    _plannings.Add(new PlanningElement(new DateTime(2013, 3, 1), new DateTime(2013, 5, 15), 0, _evenements[0], _lieux[0], 0));
        //    _plannings.Add(new PlanningElement(new DateTime(2013, 10, 31), new DateTime(2013, 11, 1), 0, _evenements[1], _lieux[1], 0));
        //    _plannings.Add(new PlanningElement(new DateTime(2013, 8, 15), new DateTime(2013, 08, 19), 0, _evenements[2], _lieux[2], 0));
        //}

        //public List<PlanningElement> Evenements
        //{
        //    get;
        //    set;
        //}

        //public List<Artiste> ReturnArtistes()
        //{
        //    return _artistes;
        //}

        //public List<Evenement> ReturnEvenements()
        //{
        //    return _evenements;
        //}

        //public List<Lieu> ReturnLieux()
        //{
        //    return _lieux;
        //}

        //public List<PlanningElement> ReturnPlanningElements()
        //{
        //    return _plannings;
        //}
    }
}
