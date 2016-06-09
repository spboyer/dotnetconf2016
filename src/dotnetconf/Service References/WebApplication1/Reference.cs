﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/PeopleService")]
    public partial class Person : object
    {
        
        private int AgeField;
        
        private string FirstField;
        
        private int IdField;
        
        private string LastField;
        
        private string MiddleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age
        {
            get
            {
                return this.AgeField;
            }
            set
            {
                this.AgeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First
        {
            get
            {
                return this.FirstField;
            }
            set
            {
                this.FirstField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last
        {
            get
            {
                return this.LastField;
            }
            set
            {
                this.LastField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Middle
        {
            get
            {
                return this.MiddleField;
            }
            set
            {
                this.MiddleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonMajor", Namespace="http://schemas.datacontract.org/2004/07/PeopleService")]
    public partial class PersonMajor : object
    {
        
        private int IdField;
        
        private WebApplication1.Address ItemPersonAddressData1Field;
        
        private WebApplication1.Address ItemPersonAddressData2Field;
        
        private WebApplication1.Person ItemPersonDataField;
        
        private WebApplication1.Person ItemPersonEmergencyContactDataField;
        
        private string ItemPhoneNumberData1Field;
        
        private string ItemPhoneNumberData2Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.Address ItemPersonAddressData1
        {
            get
            {
                return this.ItemPersonAddressData1Field;
            }
            set
            {
                this.ItemPersonAddressData1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.Address ItemPersonAddressData2
        {
            get
            {
                return this.ItemPersonAddressData2Field;
            }
            set
            {
                this.ItemPersonAddressData2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.Person ItemPersonData
        {
            get
            {
                return this.ItemPersonDataField;
            }
            set
            {
                this.ItemPersonDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.Person ItemPersonEmergencyContactData
        {
            get
            {
                return this.ItemPersonEmergencyContactDataField;
            }
            set
            {
                this.ItemPersonEmergencyContactDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemPhoneNumberData1
        {
            get
            {
                return this.ItemPhoneNumberData1Field;
            }
            set
            {
                this.ItemPhoneNumberData1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemPhoneNumberData2
        {
            get
            {
                return this.ItemPhoneNumberData2Field;
            }
            set
            {
                this.ItemPhoneNumberData2Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/PeopleService")]
    public partial class Address : object
    {
        
        private string CityField;
        
        private int IdField;
        
        private string StateField;
        
        private string StreetField;
        
        private string ZipCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street
        {
            get
            {
                return this.StreetField;
            }
            set
            {
                this.StreetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode
        {
            get
            {
                return this.ZipCodeField;
            }
            set
            {
                this.ZipCodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebApplication1.IGetPeopleService")]
    public interface IGetPeopleService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetPeopleService/GetPeopleData", ReplyAction="http://tempuri.org/IGetPeopleService/GetPeopleDataResponse")]
        System.Threading.Tasks.Task<WebApplication1.Person[]> GetPeopleDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetPeopleService/GetCompletePeople", ReplyAction="http://tempuri.org/IGetPeopleService/GetCompletePeopleResponse")]
        System.Threading.Tasks.Task<WebApplication1.PersonMajor[]> GetCompletePeopleAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    public interface IGetPeopleServiceChannel : WebApplication1.IGetPeopleService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    public partial class GetPeopleServiceClient : System.ServiceModel.ClientBase<WebApplication1.IGetPeopleService>, WebApplication1.IGetPeopleService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public GetPeopleServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(GetPeopleServiceClient.GetBindingForEndpoint(endpointConfiguration), GetPeopleServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GetPeopleServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(GetPeopleServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GetPeopleServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(GetPeopleServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GetPeopleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Person[]> GetPeopleDataAsync(int value)
        {
            return base.Channel.GetPeopleDataAsync(value);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.PersonMajor[]> GetCompletePeopleAsync(int value)
        {
            return base.Channel.GetCompletePeopleAsync(value);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGetPeopleService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IGetPeopleService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGetPeopleService))
            {
                return new System.ServiceModel.EndpointAddress("http://peopleservice.azurewebsites.net/People.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IGetPeopleService))
            {
                return new System.ServiceModel.EndpointAddress("https://peopleservice.azurewebsites.net/People.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IGetPeopleService,
            
            BasicHttpsBinding_IGetPeopleService,
        }
    }
}
