﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCSMS.Presentation.Impl.AccountService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/StartSession", ReplyAction="http://tempuri.org/IAccountService/StartSessionResponse")]
        HCSMS.Model.Session StartSession(HCSMS.Model.Account anAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/StopSession", ReplyAction="http://tempuri.org/IAccountService/StopSessionResponse")]
        void StopSession(HCSMS.Model.Session session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsLogin", ReplyAction="http://tempuri.org/IAccountService/IsLoginResponse")]
        bool IsLogin(HCSMS.Model.Session session);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : HCSMS.Presentation.Impl.AccountService.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<HCSMS.Presentation.Impl.AccountService.IAccountService>, HCSMS.Presentation.Impl.AccountService.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HCSMS.Model.Session StartSession(HCSMS.Model.Account anAccount) {
            return base.Channel.StartSession(anAccount);
        }
        
        public void StopSession(HCSMS.Model.Session session) {
            base.Channel.StopSession(session);
        }
        
        public bool IsLogin(HCSMS.Model.Session session) {
            return base.Channel.IsLogin(session);
        }
    }
}