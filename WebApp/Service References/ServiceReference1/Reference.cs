﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 msg 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HandlerMessage", ReplyAction="*")]
        WebApp.ServiceReference1.HandlerMessageResponse HandlerMessage(WebApp.ServiceReference1.HandlerMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HandlerMessage", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.ServiceReference1.HandlerMessageResponse> HandlerMessageAsync(WebApp.ServiceReference1.HandlerMessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HandlerMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HandlerMessage", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.ServiceReference1.HandlerMessageRequestBody Body;
        
        public HandlerMessageRequest() {
        }
        
        public HandlerMessageRequest(WebApp.ServiceReference1.HandlerMessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HandlerMessageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string msg;
        
        public HandlerMessageRequestBody() {
        }
        
        public HandlerMessageRequestBody(string msg) {
            this.msg = msg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HandlerMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HandlerMessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.ServiceReference1.HandlerMessageResponseBody Body;
        
        public HandlerMessageResponse() {
        }
        
        public HandlerMessageResponse(WebApp.ServiceReference1.HandlerMessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HandlerMessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HandlerMessageResult;
        
        public HandlerMessageResponseBody() {
        }
        
        public HandlerMessageResponseBody(string HandlerMessageResult) {
            this.HandlerMessageResult = HandlerMessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebApp.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebApp.ServiceReference1.WebService1Soap>, WebApp.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.ServiceReference1.HandlerMessageResponse WebApp.ServiceReference1.WebService1Soap.HandlerMessage(WebApp.ServiceReference1.HandlerMessageRequest request) {
            return base.Channel.HandlerMessage(request);
        }
        
        public string HandlerMessage(string msg) {
            WebApp.ServiceReference1.HandlerMessageRequest inValue = new WebApp.ServiceReference1.HandlerMessageRequest();
            inValue.Body = new WebApp.ServiceReference1.HandlerMessageRequestBody();
            inValue.Body.msg = msg;
            WebApp.ServiceReference1.HandlerMessageResponse retVal = ((WebApp.ServiceReference1.WebService1Soap)(this)).HandlerMessage(inValue);
            return retVal.Body.HandlerMessageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.ServiceReference1.HandlerMessageResponse> WebApp.ServiceReference1.WebService1Soap.HandlerMessageAsync(WebApp.ServiceReference1.HandlerMessageRequest request) {
            return base.Channel.HandlerMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.ServiceReference1.HandlerMessageResponse> HandlerMessageAsync(string msg) {
            WebApp.ServiceReference1.HandlerMessageRequest inValue = new WebApp.ServiceReference1.HandlerMessageRequest();
            inValue.Body = new WebApp.ServiceReference1.HandlerMessageRequestBody();
            inValue.Body.msg = msg;
            return ((WebApp.ServiceReference1.WebService1Soap)(this)).HandlerMessageAsync(inValue);
        }
    }
}
