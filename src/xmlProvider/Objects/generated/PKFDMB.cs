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
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace xmlObjectProvider.Objects.generated.PKFDMB {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.pse.pl/osp")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.pse.pl/osp", IsNullable=false)]
    public partial class Komunikat {
        
        private Naglowek naglowekField;
        
        private tTresc trescField;
        
        /// <remarks/>
        public Naglowek Naglowek {
            get {
                return this.naglowekField;
            }
            set {
                this.naglowekField = value;
            }
        }
        
        /// <remarks/>
        public tTresc Tresc {
            get {
                return this.trescField;
            }
            set {
                this.trescField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pse.pl/osp")]
    public partial class Naglowek {
        
        private string kod_komField;
        
        private System.DateTime dataField;
        
        private string kod_obiektuField;
        
        private System.DateTime data_utworzeniaField;
        
        private string wersjaField;
        
        private string idField;
        
        private string ref_idField;
        
        /// <remarks/>
        public string kod_kom {
            get {
                return this.kod_komField;
            }
            set {
                this.kod_komField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        public string kod_obiektu {
            get {
                return this.kod_obiektuField;
            }
            set {
                this.kod_obiektuField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime data_utworzenia {
            get {
                return this.data_utworzeniaField;
            }
            set {
                this.data_utworzeniaField = value;
            }
        }
        
        /// <remarks/>
        public string wersja {
            get {
                return this.wersjaField;
            }
            set {
                this.wersjaField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string ref_id {
            get {
                return this.ref_idField;
            }
            set {
                this.ref_idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pse.pl/osp")]
    public partial class tPKFDMB {
        
        private string koField;
        
        private string iDOTField;
        
        /// <remarks/>
        public string KO {
            get {
                return this.koField;
            }
            set {
                this.koField = value;
            }
        }
        
        /// <remarks/>
        public string IDOT {
            get {
                return this.iDOTField;
            }
            set {
                this.iDOTField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pse.pl/osp")]
    public partial class tTresc {
        
        private tPKFDMB fDMBField;
        
        /// <remarks/>
        public tPKFDMB FDMB {
            get {
                return this.fDMBField;
            }
            set {
                this.fDMBField = value;
            }
        }
    }
}
