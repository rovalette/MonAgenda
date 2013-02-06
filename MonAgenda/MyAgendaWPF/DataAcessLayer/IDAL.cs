using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;

namespace DataAcessLayer
{
    public interface IDAL
    {
        List<Artiste> getAllArtistes();
        List<PlanningElement> getAllEvenements();
        List<Lieu> getAllLieux();
        List<PlanningElement> getEvenementsByLieu(String lieu);
        List<Utilisateur> getUtilisateurByLogin(String login);
        void update();
    }
}
