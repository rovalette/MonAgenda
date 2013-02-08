using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public BusinessManager() { }

        public IList<EntitiesLayer.Artiste> GetArtistes()
        {
            StubDataAccessLayer.DalManager dalManager = new StubDataAccessLayer.DalManager();
            return dalManager.SelectArtistes();
        }
    }
}
