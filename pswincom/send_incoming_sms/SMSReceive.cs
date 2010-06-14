﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 
namespace send_incoming_sms {
    using System.Xml.Serialization;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Diagnostics;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SMSReceiveSoap", Namespace="http://pswin.com/SOAP/Receive")]
    public partial class SMSReceive : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReceiveSMSMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReceiveDeliveryReportOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReceiveMMSMessageOperationCompleted;
        
        /// <remarks/>
        public SMSReceive() {
            this.Url = "https://secure.pswin.com/SOAP/Receive.asmx";
        }
        
        /// <remarks/>
        public event ReceiveSMSMessageCompletedEventHandler ReceiveSMSMessageCompleted;
        
        /// <remarks/>
        public event ReceiveDeliveryReportCompletedEventHandler ReceiveDeliveryReportCompleted;
        
        /// <remarks/>
        public event ReceiveMMSMessageCompletedEventHandler ReceiveMMSMessageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://pswin.com/SOAP/Receive/ReceiveSMSMessage", RequestNamespace="http://pswin.com/SOAP/Receive", ResponseNamespace="http://pswin.com/SOAP/Receive", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ReturnValue ReceiveSMSMessage(IncomingSMSMessage m) {
            object[] results = this.Invoke("ReceiveSMSMessage", new object[] {
                        m});
            return ((ReturnValue)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReceiveSMSMessage(IncomingSMSMessage m, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReceiveSMSMessage", new object[] {
                        m}, callback, asyncState);
        }
        
        /// <remarks/>
        public ReturnValue EndReceiveSMSMessage(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ReturnValue)(results[0]));
        }
        
        /// <remarks/>
        public void ReceiveSMSMessageAsync(IncomingSMSMessage m) {
            this.ReceiveSMSMessageAsync(m, null);
        }
        
        /// <remarks/>
        public void ReceiveSMSMessageAsync(IncomingSMSMessage m, object userState) {
            if ((this.ReceiveSMSMessageOperationCompleted == null)) {
                this.ReceiveSMSMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReceiveSMSMessageOperationCompleted);
            }
            this.InvokeAsync("ReceiveSMSMessage", new object[] {
                        m}, this.ReceiveSMSMessageOperationCompleted, userState);
        }
        
        private void OnReceiveSMSMessageOperationCompleted(object arg) {
            if ((this.ReceiveSMSMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReceiveSMSMessageCompleted(this, new ReceiveSMSMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://pswin.com/SOAP/Receive/ReceiveDeliveryReport", RequestNamespace="http://pswin.com/SOAP/Receive", ResponseNamespace="http://pswin.com/SOAP/Receive", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ReturnValue ReceiveDeliveryReport(DeliveryReport dr) {
            object[] results = this.Invoke("ReceiveDeliveryReport", new object[] {
                        dr});
            return ((ReturnValue)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReceiveDeliveryReport(DeliveryReport dr, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReceiveDeliveryReport", new object[] {
                        dr}, callback, asyncState);
        }
        
        /// <remarks/>
        public ReturnValue EndReceiveDeliveryReport(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ReturnValue)(results[0]));
        }
        
        /// <remarks/>
        public void ReceiveDeliveryReportAsync(DeliveryReport dr) {
            this.ReceiveDeliveryReportAsync(dr, null);
        }
        
        /// <remarks/>
        public void ReceiveDeliveryReportAsync(DeliveryReport dr, object userState) {
            if ((this.ReceiveDeliveryReportOperationCompleted == null)) {
                this.ReceiveDeliveryReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReceiveDeliveryReportOperationCompleted);
            }
            this.InvokeAsync("ReceiveDeliveryReport", new object[] {
                        dr}, this.ReceiveDeliveryReportOperationCompleted, userState);
        }
        
        private void OnReceiveDeliveryReportOperationCompleted(object arg) {
            if ((this.ReceiveDeliveryReportCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReceiveDeliveryReportCompleted(this, new ReceiveDeliveryReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://pswin.com/SOAP/Receive/ReceiveMMSMessage", RequestNamespace="http://pswin.com/SOAP/Receive", ResponseNamespace="http://pswin.com/SOAP/Receive", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ReturnValue ReceiveMMSMessage(IncomingMMSMessage m) {
            object[] results = this.Invoke("ReceiveMMSMessage", new object[] {
                        m});
            return ((ReturnValue)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReceiveMMSMessage(IncomingMMSMessage m, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReceiveMMSMessage", new object[] {
                        m}, callback, asyncState);
        }
        
        /// <remarks/>
        public ReturnValue EndReceiveMMSMessage(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ReturnValue)(results[0]));
        }
        
        /// <remarks/>
        public void ReceiveMMSMessageAsync(IncomingMMSMessage m) {
            this.ReceiveMMSMessageAsync(m, null);
        }
        
        /// <remarks/>
        public void ReceiveMMSMessageAsync(IncomingMMSMessage m, object userState) {
            if ((this.ReceiveMMSMessageOperationCompleted == null)) {
                this.ReceiveMMSMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReceiveMMSMessageOperationCompleted);
            }
            this.InvokeAsync("ReceiveMMSMessage", new object[] {
                        m}, this.ReceiveMMSMessageOperationCompleted, userState);
        }
        
        private void OnReceiveMMSMessageOperationCompleted(object arg) {
            if ((this.ReceiveMMSMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReceiveMMSMessageCompleted(this, new ReceiveMMSMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pswin.com/SOAP/Receive")]
    public partial class IncomingSMSMessage {
        
        private string receiverNumberField;
        
        private string senderNumberField;
        
        private string textField;
        
        private string networkField;
        
        private string addressField;
        
        private GSMPosition positionField;
        
        /// <remarks/>
        public string ReceiverNumber {
            get {
                return this.receiverNumberField;
            }
            set {
                this.receiverNumberField = value;
            }
        }
        
        /// <remarks/>
        public string SenderNumber {
            get {
                return this.senderNumberField;
            }
            set {
                this.senderNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GSMPosition Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pswin.com/SOAP/Receive")]
    public partial class GSMPosition {
        
        private string longitudeField;
        
        private string lattitudeField;
        
        private string radiusField;
        
        private string countyField;
        
        private string councilField;
        
        private string councilNumberField;
        
        private string placeField;
        
        private string subPlaceField;
        
        private string zipCodeField;
        
        private string cityField;
        
        /// <remarks/>
        public string Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        public string Lattitude {
            get {
                return this.lattitudeField;
            }
            set {
                this.lattitudeField = value;
            }
        }
        
        /// <remarks/>
        public string Radius {
            get {
                return this.radiusField;
            }
            set {
                this.radiusField = value;
            }
        }
        
        /// <remarks/>
        public string County {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        public string Council {
            get {
                return this.councilField;
            }
            set {
                this.councilField = value;
            }
        }
        
        /// <remarks/>
        public string CouncilNumber {
            get {
                return this.councilNumberField;
            }
            set {
                this.councilNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Place {
            get {
                return this.placeField;
            }
            set {
                this.placeField = value;
            }
        }
        
        /// <remarks/>
        public string SubPlace {
            get {
                return this.subPlaceField;
            }
            set {
                this.subPlaceField = value;
            }
        }
        
        /// <remarks/>
        public string ZipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pswin.com/SOAP/Receive")]
    public partial class IncomingMMSMessage {
        
        private string receiverNumberField;
        
        private string senderNumberField;
        
        private string subjectField;
        
        private string networkField;
        
        private string addressField;
        
        private GSMPosition positionField;
        
        private byte[] dataField;
        
        /// <remarks/>
        public string ReceiverNumber {
            get {
                return this.receiverNumberField;
            }
            set {
                this.receiverNumberField = value;
            }
        }
        
        /// <remarks/>
        public string SenderNumber {
            get {
                return this.senderNumberField;
            }
            set {
                this.senderNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GSMPosition Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pswin.com/SOAP/Receive")]
    public partial class DeliveryReport {
        
        private string stateField;
        
        private string receiverNumberField;
        
        private string deliveryTimeField;
        
        private string referenceField;
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string ReceiverNumber {
            get {
                return this.receiverNumberField;
            }
            set {
                this.receiverNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string DeliveryTime {
            get {
                return this.deliveryTimeField;
            }
            set {
                this.deliveryTimeField = value;
            }
        }
        
        /// <remarks/>
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pswin.com/SOAP/Receive")]
    public partial class ReturnValue {
        
        private int codeField;
        
        private string descriptionField;
        
        private string referenceField;
        
        /// <remarks/>
        public int Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void ReceiveSMSMessageCompletedEventHandler(object sender, ReceiveSMSMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReceiveSMSMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReceiveSMSMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReturnValue Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReturnValue)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void ReceiveDeliveryReportCompletedEventHandler(object sender, ReceiveDeliveryReportCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReceiveDeliveryReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReceiveDeliveryReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReturnValue Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReturnValue)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void ReceiveMMSMessageCompletedEventHandler(object sender, ReceiveMMSMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReceiveMMSMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReceiveMMSMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReturnValue Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReturnValue)(this.results[0]));
            }
        }
    }
}
