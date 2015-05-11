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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/R-1014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/R-1014", IsNullable=true)]
    public partial class CROZParticipantAddressData : InformationObject<CROZParticipantAddressData> {
        
        private string districtCodeField;
        
        private string districtNameField;
        
        private string municipalityCodeField;
        
        private string municipalityNameField;
        
        private string territorialUnitEKATTECodeField;
        
        private string territorialUnitEKATTENameField;
        
        private string postCodeField;
        
        private string addressDescriptionField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DistrictCode {
            get {
                return this.districtCodeField;
            }
            set {
                if ((this.districtCodeField != null)) {
                    if ((districtCodeField.Equals(value) != true)) {
                        this.districtCodeField = value;
                        this.OnPropertyChanged("DistrictCode");
                    }
                }
                else {
                    this.districtCodeField = value;
                    this.OnPropertyChanged("DistrictCode");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DistrictName {
            get {
                return this.districtNameField;
            }
            set {
                if ((this.districtNameField != null)) {
                    if ((districtNameField.Equals(value) != true)) {
                        this.districtNameField = value;
                        this.OnPropertyChanged("DistrictName");
                    }
                }
                else {
                    this.districtNameField = value;
                    this.OnPropertyChanged("DistrictName");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string MunicipalityCode {
            get {
                return this.municipalityCodeField;
            }
            set {
                if ((this.municipalityCodeField != null)) {
                    if ((municipalityCodeField.Equals(value) != true)) {
                        this.municipalityCodeField = value;
                        this.OnPropertyChanged("MunicipalityCode");
                    }
                }
                else {
                    this.municipalityCodeField = value;
                    this.OnPropertyChanged("MunicipalityCode");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string MunicipalityName {
            get {
                return this.municipalityNameField;
            }
            set {
                if ((this.municipalityNameField != null)) {
                    if ((municipalityNameField.Equals(value) != true)) {
                        this.municipalityNameField = value;
                        this.OnPropertyChanged("MunicipalityName");
                    }
                }
                else {
                    this.municipalityNameField = value;
                    this.OnPropertyChanged("MunicipalityName");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string TerritorialUnitEKATTECode {
            get {
                return this.territorialUnitEKATTECodeField;
            }
            set {
                if ((this.territorialUnitEKATTECodeField != null)) {
                    if ((territorialUnitEKATTECodeField.Equals(value) != true)) {
                        this.territorialUnitEKATTECodeField = value;
                        this.OnPropertyChanged("TerritorialUnitEKATTECode");
                    }
                }
                else {
                    this.territorialUnitEKATTECodeField = value;
                    this.OnPropertyChanged("TerritorialUnitEKATTECode");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string TerritorialUnitEKATTEName {
            get {
                return this.territorialUnitEKATTENameField;
            }
            set {
                if ((this.territorialUnitEKATTENameField != null)) {
                    if ((territorialUnitEKATTENameField.Equals(value) != true)) {
                        this.territorialUnitEKATTENameField = value;
                        this.OnPropertyChanged("TerritorialUnitEKATTEName");
                    }
                }
                else {
                    this.territorialUnitEKATTENameField = value;
                    this.OnPropertyChanged("TerritorialUnitEKATTEName");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                if ((this.postCodeField != null)) {
                    if ((postCodeField.Equals(value) != true)) {
                        this.postCodeField = value;
                        this.OnPropertyChanged("PostCode");
                    }
                }
                else {
                    this.postCodeField = value;
                    this.OnPropertyChanged("PostCode");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string AddressDescription {
            get {
                return this.addressDescriptionField;
            }
            set {
                if ((this.addressDescriptionField != null)) {
                    if ((addressDescriptionField.Equals(value) != true)) {
                        this.addressDescriptionField = value;
                        this.OnPropertyChanged("AddressDescription");
                    }
                }
                else {
                    this.addressDescriptionField = value;
                    this.OnPropertyChanged("AddressDescription");
                }
            }
        }
    }
}
