﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18033
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceAgenda.ServiceAgendaReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ArtisteWS", Namespace="http://schemas.datacontract.org/2004/07/WebServiceAgenda.Business")]
    [System.SerializableAttribute()]
    public partial class ArtisteWS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Guid {
            get {
                return this.GuidField;
            }
            set {
                if ((object.ReferenceEquals(this.GuidField, value) != true)) {
                    this.GuidField = value;
                    this.RaisePropertyChanged("Guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EvenementWS", Namespace="http://schemas.datacontract.org/2004/07/WebServiceAgenda.Business")]
    [System.SerializableAttribute()]
    public partial class EvenementWS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LieuWS", Namespace="http://schemas.datacontract.org/2004/07/WebServiceAgenda.Business")]
    [System.SerializableAttribute()]
    public partial class LieuWS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlanningElementWS", Namespace="http://schemas.datacontract.org/2004/07/WebServiceAgenda.Business")]
    [System.SerializableAttribute()]
    public partial class PlanningElementWS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WebServiceAgenda")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAgendaReference.IServiceAgenda")]
    public interface IServiceAgenda {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/getAllArtistes", ReplyAction="http://tempuri.org/IServiceAgenda/getAllArtistesResponse")]
        WebServiceAgenda.ServiceAgendaReference.ArtisteWS[] getAllArtistes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/getAllArtistes", ReplyAction="http://tempuri.org/IServiceAgenda/getAllArtistesResponse")]
        System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.ArtisteWS[]> getAllArtistesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/getAllEvenements", ReplyAction="http://tempuri.org/IServiceAgenda/getAllEvenementsResponse")]
        WebServiceAgenda.ServiceAgendaReference.EvenementWS[] getAllEvenements();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/getAllEvenements", ReplyAction="http://tempuri.org/IServiceAgenda/getAllEvenementsResponse")]
        System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.EvenementWS[]> getAllEvenementsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/getAllLieux", ReplyAction="http://tempuri.org/IServiceAgenda/getAllLieuxResponse")]
        WebServiceAgenda.ServiceAgendaReference.LieuWS[] getAllLieux();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/getAllLieux", ReplyAction="http://tempuri.org/IServiceAgenda/getAllLieuxResponse")]
        System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.LieuWS[]> getAllLieuxAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/checkUser", ReplyAction="http://tempuri.org/IServiceAgenda/checkUserResponse")]
        bool checkUser(string login, string mdp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/checkUser", ReplyAction="http://tempuri.org/IServiceAgenda/checkUserResponse")]
        System.Threading.Tasks.Task<bool> checkUserAsync(string login, string mdp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/nbPlacesDisponible", ReplyAction="http://tempuri.org/IServiceAgenda/nbPlacesDisponibleResponse")]
        int nbPlacesDisponible(WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/nbPlacesDisponible", ReplyAction="http://tempuri.org/IServiceAgenda/nbPlacesDisponibleResponse")]
        System.Threading.Tasks.Task<int> nbPlacesDisponibleAsync(WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/ReserverPlace", ReplyAction="http://tempuri.org/IServiceAgenda/ReserverPlaceResponse")]
        int ReserverPlace(int nbPlaces, WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/ReserverPlace", ReplyAction="http://tempuri.org/IServiceAgenda/ReserverPlaceResponse")]
        System.Threading.Tasks.Task<int> ReserverPlaceAsync(int nbPlaces, WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceAgenda/GetDataUsingDataContractResponse")]
        WebServiceAgenda.ServiceAgendaReference.CompositeType GetDataUsingDataContract(WebServiceAgenda.ServiceAgendaReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgenda/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceAgenda/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.CompositeType> GetDataUsingDataContractAsync(WebServiceAgenda.ServiceAgendaReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAgendaChannel : WebServiceAgenda.ServiceAgendaReference.IServiceAgenda, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAgendaClient : System.ServiceModel.ClientBase<WebServiceAgenda.ServiceAgendaReference.IServiceAgenda>, WebServiceAgenda.ServiceAgendaReference.IServiceAgenda {
        
        public ServiceAgendaClient() {
        }
        
        public ServiceAgendaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAgendaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAgendaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAgendaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebServiceAgenda.ServiceAgendaReference.ArtisteWS[] getAllArtistes() {
            return base.Channel.getAllArtistes();
        }
        
        public System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.ArtisteWS[]> getAllArtistesAsync() {
            return base.Channel.getAllArtistesAsync();
        }
        
        public WebServiceAgenda.ServiceAgendaReference.EvenementWS[] getAllEvenements() {
            return base.Channel.getAllEvenements();
        }
        
        public System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.EvenementWS[]> getAllEvenementsAsync() {
            return base.Channel.getAllEvenementsAsync();
        }
        
        public WebServiceAgenda.ServiceAgendaReference.LieuWS[] getAllLieux() {
            return base.Channel.getAllLieux();
        }
        
        public System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.LieuWS[]> getAllLieuxAsync() {
            return base.Channel.getAllLieuxAsync();
        }
        
        public bool checkUser(string login, string mdp) {
            return base.Channel.checkUser(login, mdp);
        }
        
        public System.Threading.Tasks.Task<bool> checkUserAsync(string login, string mdp) {
            return base.Channel.checkUserAsync(login, mdp);
        }
        
        public int nbPlacesDisponible(WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements) {
            return base.Channel.nbPlacesDisponible(pElements);
        }
        
        public System.Threading.Tasks.Task<int> nbPlacesDisponibleAsync(WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements) {
            return base.Channel.nbPlacesDisponibleAsync(pElements);
        }
        
        public int ReserverPlace(int nbPlaces, WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements) {
            return base.Channel.ReserverPlace(nbPlaces, pElements);
        }
        
        public System.Threading.Tasks.Task<int> ReserverPlaceAsync(int nbPlaces, WebServiceAgenda.ServiceAgendaReference.PlanningElementWS pElements) {
            return base.Channel.ReserverPlaceAsync(nbPlaces, pElements);
        }
        
        public WebServiceAgenda.ServiceAgendaReference.CompositeType GetDataUsingDataContract(WebServiceAgenda.ServiceAgendaReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WebServiceAgenda.ServiceAgendaReference.CompositeType> GetDataUsingDataContractAsync(WebServiceAgenda.ServiceAgendaReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}