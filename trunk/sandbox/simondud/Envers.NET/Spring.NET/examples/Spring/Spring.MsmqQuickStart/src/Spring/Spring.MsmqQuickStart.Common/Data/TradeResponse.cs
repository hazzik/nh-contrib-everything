﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 
namespace Spring.MsmqQuickStart.Common.Data {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.springframework.net/nms/common/2008-08-05")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.springframework.net/nms/common/2008-08-05", IsNullable=false)]
    public partial class TradeResponse {
        
        private string tickerField;
        
        private long quantityField;
        
        private decimal priceField;
        
        private string orderTypeField;
        
        private string confirmationNumberField;
        
        private bool errorField;
        
        private string errorMessageField;
        
        /// <remarks/>
        public string Ticker {
            get {
                return this.tickerField;
            }
            set {
                this.tickerField = value;
            }
        }
        
        /// <remarks/>
        public long Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public decimal Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string OrderType {
            get {
                return this.orderTypeField;
            }
            set {
                this.orderTypeField = value;
            }
        }
        
        /// <remarks/>
        public string ConfirmationNumber {
            get {
                return this.confirmationNumberField;
            }
            set {
                this.confirmationNumberField = value;
            }
        }
        
        /// <remarks/>
        public bool Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        public string ErrorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
            }
        }
    }
}
