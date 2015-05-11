// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000005")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000005", IsNullable=true)]
    public partial class PersonNames : InformationObject<PersonNames> {
        
        private string firstField;
        
        private string middleField;
        
        private string lastField;
        
        private string pseudonimField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string First {
            get {
                return this.firstField;
            }
            set {
                if ((this.firstField != null)) {
                    if ((firstField.Equals(value) != true)) {
                        this.firstField = value;
                        this.OnPropertyChanged("First");
                    }
                }
                else {
                    this.firstField = value;
                    this.OnPropertyChanged("First");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Middle {
            get {
                return this.middleField;
            }
            set {
                if ((this.middleField != null)) {
                    if ((middleField.Equals(value) != true)) {
                        this.middleField = value;
                        this.OnPropertyChanged("Middle");
                    }
                }
                else {
                    this.middleField = value;
                    this.OnPropertyChanged("Middle");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Last {
            get {
                return this.lastField;
            }
            set {
                if ((this.lastField != null)) {
                    if ((lastField.Equals(value) != true)) {
                        this.lastField = value;
                        this.OnPropertyChanged("Last");
                    }
                }
                else {
                    this.lastField = value;
                    this.OnPropertyChanged("Last");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Pseudonim {
            get {
                return this.pseudonimField;
            }
            set {
                if ((this.pseudonimField != null)) {
                    if ((pseudonimField.Equals(value) != true)) {
                        this.pseudonimField = value;
                        this.OnPropertyChanged("Pseudonim");
                    }
                }
                else {
                    this.pseudonimField = value;
                    this.OnPropertyChanged("Pseudonim");
                }
            }
        }
    }
}
