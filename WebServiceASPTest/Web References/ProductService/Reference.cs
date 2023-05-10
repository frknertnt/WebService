﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebServiceASPTest.ProductService {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Security securityValueField;
        
        private System.Threading.SendOrPostCallback EditProductOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteProductOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductByIDOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::WebServiceASPTest.Properties.Settings.Default.WebServiceASPTest_ProductService_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public Security SecurityValue {
            get {
                return this.securityValueField;
            }
            set {
                this.securityValueField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event EditProductCompletedEventHandler EditProductCompleted;
        
        /// <remarks/>
        public event DeleteProductCompletedEventHandler DeleteProductCompleted;
        
        /// <remarks/>
        public event GetProductsCompletedEventHandler GetProductsCompleted;
        
        /// <remarks/>
        public event GetProductByIDCompletedEventHandler GetProductByIDCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EditProduct", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public OutputType EditProduct(Product product) {
            object[] results = this.Invoke("EditProduct", new object[] {
                        product});
            return ((OutputType)(results[0]));
        }
        
        /// <remarks/>
        public void EditProductAsync(Product product) {
            this.EditProductAsync(product, null);
        }
        
        /// <remarks/>
        public void EditProductAsync(Product product, object userState) {
            if ((this.EditProductOperationCompleted == null)) {
                this.EditProductOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditProductOperationCompleted);
            }
            this.InvokeAsync("EditProduct", new object[] {
                        product}, this.EditProductOperationCompleted, userState);
        }
        
        private void OnEditProductOperationCompleted(object arg) {
            if ((this.EditProductCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditProductCompleted(this, new EditProductCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteProduct", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public OutputType DeleteProduct(string productIdentity) {
            object[] results = this.Invoke("DeleteProduct", new object[] {
                        productIdentity});
            return ((OutputType)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteProductAsync(string productIdentity) {
            this.DeleteProductAsync(productIdentity, null);
        }
        
        /// <remarks/>
        public void DeleteProductAsync(string productIdentity, object userState) {
            if ((this.DeleteProductOperationCompleted == null)) {
                this.DeleteProductOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteProductOperationCompleted);
            }
            this.InvokeAsync("DeleteProduct", new object[] {
                        productIdentity}, this.DeleteProductOperationCompleted, userState);
        }
        
        private void OnDeleteProductOperationCompleted(object arg) {
            if ((this.DeleteProductCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteProductCompleted(this, new DeleteProductCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProducts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Product[] GetProducts() {
            object[] results = this.Invoke("GetProducts", new object[0]);
            return ((Product[])(results[0]));
        }
        
        /// <remarks/>
        public void GetProductsAsync() {
            this.GetProductsAsync(null);
        }
        
        /// <remarks/>
        public void GetProductsAsync(object userState) {
            if ((this.GetProductsOperationCompleted == null)) {
                this.GetProductsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductsOperationCompleted);
            }
            this.InvokeAsync("GetProducts", new object[0], this.GetProductsOperationCompleted, userState);
        }
        
        private void OnGetProductsOperationCompleted(object arg) {
            if ((this.GetProductsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductsCompleted(this, new GetProductsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Product GetProductByID(string productIdentity) {
            object[] results = this.Invoke("GetProductByID", new object[] {
                        productIdentity});
            return ((Product)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductByIDAsync(string productIdentity) {
            this.GetProductByIDAsync(productIdentity, null);
        }
        
        /// <remarks/>
        public void GetProductByIDAsync(string productIdentity, object userState) {
            if ((this.GetProductByIDOperationCompleted == null)) {
                this.GetProductByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductByIDOperationCompleted);
            }
            this.InvokeAsync("GetProductByID", new object[] {
                        productIdentity}, this.GetProductByIDOperationCompleted, userState);
        }
        
        private void OnGetProductByIDOperationCompleted(object arg) {
            if ((this.GetProductByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductByIDCompleted(this, new GetProductByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class Security : System.Web.Services.Protocols.SoapHeader {
        
        private string usernameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Product {
        
        private int idField;
        
        private string identifyField;
        
        private string descriptionField;
        
        private string explanationField;
        
        private int stockField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Identify {
            get {
                return this.identifyField;
            }
            set {
                this.identifyField = value;
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
        public string Explanation {
            get {
                return this.explanationField;
            }
            set {
                this.explanationField = value;
            }
        }
        
        /// <remarks/>
        public int Stock {
            get {
                return this.stockField;
            }
            set {
                this.stockField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum OutputType {
        
        /// <remarks/>
        TransactionSuccessfull,
        
        /// <remarks/>
        TransactionFailed,
        
        /// <remarks/>
        Undefined,
        
        /// <remarks/>
        RegisteredProduct,
        
        /// <remarks/>
        NewProduct,
        
        /// <remarks/>
        ProductNotFound,
        
        /// <remarks/>
        SecurityError,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void EditProductCompletedEventHandler(object sender, EditProductCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EditProductCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EditProductCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OutputType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OutputType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void DeleteProductCompletedEventHandler(object sender, DeleteProductCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteProductCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteProductCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OutputType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OutputType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetProductsCompletedEventHandler(object sender, GetProductsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Product[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Product[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetProductByIDCompletedEventHandler(object sender, GetProductByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Product Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Product)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591