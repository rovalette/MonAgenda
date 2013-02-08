using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        private IList<EntitiesLayer.Artiste> _artistes;

        public DalManager() 
        {
            _artistes = new List<EntitiesLayer.Artiste>();
            _artistes.Add(new EntitiesLayer.Artiste("Leonard",
                                                    "De Vinci", 
                                                    new DateTime(1452, 04, 15), 
                                                    new DateTime(1519,05,2)));

            _artistes.Add(new EntitiesLayer.Artiste("Oscar-Claude",
                                                    "Monnet",
                                                    new DateTime(1840, 11, 14),
                                                    new DateTime(1926, 12, 5)));

            _artistes.Add(new EntitiesLayer.Artiste("Pierre-Aguste",
                                          "Renoir",
                                          new DateTime(1841, 02, 25),
                                          new DateTime(1919, 12, 3)));

        }

        public IList<EntitiesLayer.Artiste> SelectArtistes()
        {
            return _artistes;
        }
    }
}
