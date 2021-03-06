﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceAgenda.Business;

namespace WebServiceAgenda
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceAgenda
    {

        [OperationContract]
        List<ArtisteWS> getAllArtistes();

        [OperationContract]
        ArtisteWS getArtiste(String Guid);

        [OperationContract]
        List<EvenementWS> getAllEvenements();

        [OperationContract]
        List<EvenementWS> getEvenementsByArtiste(ArtisteWS Artiste);

        [OperationContract]
        List<LieuWS> getAllLieux();

        [OperationContract]
        List<LieuWS> getLieuxEvents(String evenement);

        [OperationContract]
        bool checkUser(string login, string mdp);

        [OperationContract]
        int nbPlacesDisponible(PlanningElementWS pElements);

        [OperationContract]
        int ReserverPlace(int nbPlaces, PlanningElementWS pElements);
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
