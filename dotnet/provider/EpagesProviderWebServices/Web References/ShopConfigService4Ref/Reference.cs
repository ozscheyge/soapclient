//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpagesProviderWebServices.ShopConfigService4Ref {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="bind_ShopConfig_SOAP", Namespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TLocalizedValue))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TAttribute))]
    public partial class ShopConfigService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public ShopConfigService() {
            this.Url = "http://localhost/epages/Site.soap";
        }
        
        public ShopConfigService(string url) {
            this.Url = url;
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ShopConfigService/2007/03#create", RequestNamespace="urn://epages.de/WebService/ShopConfigService/2007/03", ResponseNamespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("ShopID")]
        public int create(TCreateShop CreateShopData) {
            object[] results = this.Invoke("create", new object[] {
                        CreateShopData});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begincreate(TCreateShop CreateShopData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("create", new object[] {
                        CreateShopData}, callback, asyncState);
        }
        
        /// <remarks/>
        public int Endcreate(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ShopConfigService/2007/03#delete", RequestNamespace="urn://epages.de/WebService/ShopConfigService/2007/03", ResponseNamespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
        public void delete(TShopRef ShopRef) {
            this.Invoke("delete", new object[] {
                        ShopRef});
        }
        
        /// <remarks/>
        public System.IAsyncResult Begindelete(TShopRef ShopRef, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("delete", new object[] {
                        ShopRef}, callback, asyncState);
        }
        
        /// <remarks/>
        public void Enddelete(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ShopConfigService/2007/03#exists", RequestNamespace="urn://epages.de/WebService/ShopConfigService/2007/03", ResponseNamespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("Exists")]
        public bool exists(TShopRef ShopRef) {
            object[] results = this.Invoke("exists", new object[] {
                        ShopRef});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexists(TShopRef ShopRef, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exists", new object[] {
                        ShopRef}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool Endexists(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ShopConfigService/2007/03#update", RequestNamespace="urn://epages.de/WebService/ShopConfigService/2007/03", ResponseNamespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
        public void update(TUpdateShop ShopData) {
            this.Invoke("update", new object[] {
                        ShopData});
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginupdate(TUpdateShop ShopData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("update", new object[] {
                        ShopData}, callback, asyncState);
        }
        
        /// <remarks/>
        public void Endupdate(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ShopConfigService/2007/03#getInfo", RequestNamespace="urn://epages.de/WebService/ShopConfigService/2007/03", ResponseNamespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("ShopInfo")]
        public TInfoShop getInfo(TInfoShop_Input ShopInfo) {
            object[] results = this.Invoke("getInfo", new object[] {
                        ShopInfo});
            return ((TInfoShop)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetInfo(TInfoShop_Input ShopInfo, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getInfo", new object[] {
                        ShopInfo}, callback, asyncState);
        }
        
        /// <remarks/>
        public TInfoShop EndgetInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TInfoShop)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ShopConfigService/2007/03#getAllInfo", RequestNamespace="urn://epages.de/WebService/ShopConfigService/2007/03", ResponseNamespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("ShopInfos")]
        public TInfoShop[] getAllInfo() {
            object[] results = this.Invoke("getAllInfo", new object[0]);
            return ((TInfoShop[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAllInfo(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAllInfo", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public TInfoShop[] EndgetAllInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TInfoShop[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ShopConfigService/2007/03#deleteShopRef", RequestNamespace="urn://epages.de/WebService/ShopConfigService/2007/03", ResponseNamespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
        public void deleteShopRef(TShopRef ShopRef) {
            this.Invoke("deleteShopRef", new object[] {
                        ShopRef});
        }
        
        /// <remarks/>
        public System.IAsyncResult BegindeleteShopRef(TShopRef ShopRef, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("deleteShopRef", new object[] {
                        ShopRef}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EnddeleteShopRef(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
    public partial class TCreateShop {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string ShopType;
        
        /// <remarks/>
        public string Database;
        
        /// <remarks/>
        public string ShopAlias;
        
        /// <remarks/>
        public string[] ImportFiles;
        
        /// <remarks/>
        public bool IsClosed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsClosedSpecified;
        
        /// <remarks/>
        public bool IsTrialShop;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsTrialShopSpecified;
        
        /// <remarks/>
        public bool IsInternalTestShop;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsInternalTestShopSpecified;
        
        /// <remarks/>
        public string DomainName;
        
        /// <remarks/>
        public bool HasSSLCertificate;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HasSSLCertificateSpecified;
        
        /// <remarks/>
        public string WebServerScriptNamePart;
        
        /// <remarks/>
        public string PublicFilesDir;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/EpagesTypes/2005/01")]
    public partial class TLocalizedValue {
        
        /// <remarks/>
        public string LanguageCode;
        
        /// <remarks/>
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/EpagesTypes/2005/01")]
    public partial class TAttribute {
        
        /// <remarks/>
        public string Name;
        
        /// <remarks/>
        public string Value;
        
        /// <remarks/>
        public TLocalizedValue[] LocalizedValues;
        
        /// <remarks/>
        public string Type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
    public partial class TInfoShop {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string ShopType;
        
        /// <remarks/>
        public string Database;
        
        /// <remarks/>
        public string Provider;
        
        /// <remarks/>
        public string ObjectPath;
        
        /// <remarks/>
        public bool IsClosed;
        
        /// <remarks/>
        public bool IsDeleted;
        
        /// <remarks/>
        public bool IsTrialShop;
        
        /// <remarks/>
        public bool IsInternalTestShop;
        
        /// <remarks/>
        public string DomainName;
        
        /// <remarks/>
        public bool HasSSLCertificate;
        
        /// <remarks/>
        public string WebServerScriptNamePart;
        
        /// <remarks/>
        public TAttribute[] Attributes;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
    public partial class TInfoShop_Input {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string[] Attributes;
        
        /// <remarks/>
        public string[] Languages;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
    public partial class TUpdateShop {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string ShopType;
        
        /// <remarks/>
        public string Database;
        
        /// <remarks/>
        public string ShopAlias;
        
        /// <remarks/>
        public string[] ImportFiles;
        
        /// <remarks/>
        public bool IsClosed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsClosedSpecified;
        
        /// <remarks/>
        public bool IsTrialShop;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsTrialShopSpecified;
        
        /// <remarks/>
        public bool IsInternalTestShop;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsInternalTestShopSpecified;
        
        /// <remarks/>
        public string DomainName;
        
        /// <remarks/>
        public bool HasSSLCertificate;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HasSSLCertificateSpecified;
        
        /// <remarks/>
        public string WebServerScriptNamePart;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ShopConfigService/2007/03")]
    public partial class TShopRef {
        
        /// <remarks/>
        public string Alias;
    }
}
