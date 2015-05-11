// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000014", IsNullable=true)]
    public partial class ForeignEntityBasicData : InformationObject<ForeignEntityBasicData> {
        
        private string foreignEntityNameField;
        
        private string countryISO3166TwoLetterCodeField;
        
        private string countryNameCyrillicField;
        
        private string[] itemsField;

        private ItemChoiceTypeForeignEntityData[] itemsElementNameField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ForeignEntityName {
            get {
                return this.foreignEntityNameField;
            }
            set {
                if ((this.foreignEntityNameField != null)) {
                    if ((foreignEntityNameField.Equals(value) != true)) {
                        this.foreignEntityNameField = value;
                        this.OnPropertyChanged("ForeignEntityName");
                    }
                }
                else {
                    this.foreignEntityNameField = value;
                    this.OnPropertyChanged("ForeignEntityName");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CountryISO3166TwoLetterCode {
            get {
                return this.countryISO3166TwoLetterCodeField;
            }
            set {
                if ((this.countryISO3166TwoLetterCodeField != null)) {
                    if ((countryISO3166TwoLetterCodeField.Equals(value) != true)) {
                        this.countryISO3166TwoLetterCodeField = value;
                        this.OnPropertyChanged("CountryISO3166TwoLetterCode");
                    }
                }
                else {
                    this.countryISO3166TwoLetterCodeField = value;
                    this.OnPropertyChanged("CountryISO3166TwoLetterCode");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CountryNameCyrillic {
            get {
                return this.countryNameCyrillicField;
            }
            set {
                if ((this.countryNameCyrillicField != null)) {
                    if ((countryNameCyrillicField.Equals(value) != true)) {
                        this.countryNameCyrillicField = value;
                        this.OnPropertyChanged("CountryNameCyrillic");
                    }
                }
                else {
                    this.countryNameCyrillicField = value;
                    this.OnPropertyChanged("CountryNameCyrillic");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ForeignEntityIdentifier", typeof(string), Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("ForeignEntityOtherData", typeof(string), Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("ForeignEntityRegister", typeof(string), Order=3)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                if ((this.itemsField != null)) {
                    if ((itemsField.Equals(value) != true)) {
                        this.itemsField = value;
                        this.OnPropertyChanged("Items");
                    }
                }
                else {
                    this.itemsField = value;
                    this.OnPropertyChanged("Items");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=4)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceTypeForeignEntityData[] ItemsElementName
        {
            get {
                return this.itemsElementNameField;
            }
            set {
                if ((this.itemsElementNameField != null))
                {
                    if ((itemsElementNameField.Equals(value) != true))
                    {
                        this.itemsElementNameField = value;
                        this.OnPropertyChanged("ItemsElementName");
                    }
                }
                else
                {
                    this.itemsElementNameField = value;
                    this.OnPropertyChanged("ItemsElementName");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000014", IncludeInSchema=false)]
    public enum ItemChoiceTypeForeignEntityData
    {
        
        /// <remarks/>
        ForeignEntityIdentifier,
        
        /// <remarks/>
        ForeignEntityOtherData,
        
        /// <remarks/>
        ForeignEntityRegister,
    }
}
