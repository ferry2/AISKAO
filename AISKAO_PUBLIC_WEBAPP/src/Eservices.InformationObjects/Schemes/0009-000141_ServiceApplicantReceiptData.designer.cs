// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings>TechnoLogica.Eservices.InformationObjects.Nomenclatures</CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using TechnoLogica.Eservices.InformationObjects.Nomenclatures;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ereg.egov.bg/segment/0009-000141")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ereg.egov.bg/segment/0009-000141", IsNullable = true)]
    public partial class ServiceApplicantReceiptData : InformationObject<ServiceApplicantReceiptData>
    {

        private ServiceResultReceiptMethod serviceResultReceiptMethodField;

        private bool serviceResultReceiptMethodFieldSpecified;

        private object itemField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ServiceResultReceiptMethod ServiceResultReceiptMethod
        {
            get
            {
                return this.serviceResultReceiptMethodField;
            }
            set
            {
                if ((serviceResultReceiptMethodField.Equals(value) != true))
                {
                    this.serviceResultReceiptMethodField = value;
                    this.OnPropertyChanged("ServiceResultReceiptMethod");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceResultReceiptMethodSpecified
        {
            get
            {
                return this.serviceResultReceiptMethodFieldSpecified;
            }
            set
            {
                if ((serviceResultReceiptMethodFieldSpecified.Equals(value) != true))
                {
                    this.serviceResultReceiptMethodFieldSpecified = value;
                    this.OnPropertyChanged("ServiceResultReceiptMethodSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ApplicantAdress", typeof(ServiceApplicantReceiptDataApplicantAdress), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("MunicipalityAdministrationAdress", typeof(ServiceApplicantReceiptDataMunicipalityAdministrationAdress), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("PostOfficeBox", typeof(string), Order = 1)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                if ((this.itemField != null))
                {
                    if ((itemField.Equals(value) != true))
                    {
                        this.itemField = value;
                        this.OnPropertyChanged("Item");
                    }
                }
                else
                {
                    this.itemField = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ereg.egov.bg/segment/0009-000141")]
    public partial class ServiceApplicantReceiptDataApplicantAdress : InformationObject<ServiceApplicantReceiptDataApplicantAdress>
    {

        private string districtCodeField;

        private string districtNameField;

        private string municipalityCodeField;

        private string municipalityNameField;

        private string settlementCodeField;

        private string settlementNameField;

        private string postCodeField;

        private string addressDescriptionField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string DistrictCode
        {
            get
            {
                return this.districtCodeField;
            }
            set
            {
                if ((this.districtCodeField != null))
                {
                    if ((districtCodeField.Equals(value) != true))
                    {
                        this.districtCodeField = value;
                        this.OnPropertyChanged("DistrictCode");
                    }
                }
                else
                {
                    this.districtCodeField = value;
                    this.OnPropertyChanged("DistrictCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string DistrictName
        {
            get
            {
                return this.districtNameField;
            }
            set
            {
                if ((this.districtNameField != null))
                {
                    if ((districtNameField.Equals(value) != true))
                    {
                        this.districtNameField = value;
                        this.OnPropertyChanged("DistrictName");
                    }
                }
                else
                {
                    this.districtNameField = value;
                    this.OnPropertyChanged("DistrictName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string MunicipalityCode
        {
            get
            {
                return this.municipalityCodeField;
            }
            set
            {
                if ((this.municipalityCodeField != null))
                {
                    if ((municipalityCodeField.Equals(value) != true))
                    {
                        this.municipalityCodeField = value;
                        this.OnPropertyChanged("MunicipalityCode");
                    }
                }
                else
                {
                    this.municipalityCodeField = value;
                    this.OnPropertyChanged("MunicipalityCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string MunicipalityName
        {
            get
            {
                return this.municipalityNameField;
            }
            set
            {
                if ((this.municipalityNameField != null))
                {
                    if ((municipalityNameField.Equals(value) != true))
                    {
                        this.municipalityNameField = value;
                        this.OnPropertyChanged("MunicipalityName");
                    }
                }
                else
                {
                    this.municipalityNameField = value;
                    this.OnPropertyChanged("MunicipalityName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string SettlementCode
        {
            get
            {
                return this.settlementCodeField;
            }
            set
            {
                if ((this.settlementCodeField != null))
                {
                    if ((settlementCodeField.Equals(value) != true))
                    {
                        this.settlementCodeField = value;
                        this.OnPropertyChanged("SettlementCode");
                    }
                }
                else
                {
                    this.settlementCodeField = value;
                    this.OnPropertyChanged("SettlementCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string SettlementName
        {
            get
            {
                return this.settlementNameField;
            }
            set
            {
                if ((this.settlementNameField != null))
                {
                    if ((settlementNameField.Equals(value) != true))
                    {
                        this.settlementNameField = value;
                        this.OnPropertyChanged("SettlementName");
                    }
                }
                else
                {
                    this.settlementNameField = value;
                    this.OnPropertyChanged("SettlementName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string PostCode
        {
            get
            {
                return this.postCodeField;
            }
            set
            {
                if ((this.postCodeField != null))
                {
                    if ((postCodeField.Equals(value) != true))
                    {
                        this.postCodeField = value;
                        this.OnPropertyChanged("PostCode");
                    }
                }
                else
                {
                    this.postCodeField = value;
                    this.OnPropertyChanged("PostCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string AddressDescription
        {
            get
            {
                return this.addressDescriptionField;
            }
            set
            {
                if ((this.addressDescriptionField != null))
                {
                    if ((addressDescriptionField.Equals(value) != true))
                    {
                        this.addressDescriptionField = value;
                        this.OnPropertyChanged("AddressDescription");
                    }
                }
                else
                {
                    this.addressDescriptionField = value;
                    this.OnPropertyChanged("AddressDescription");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ereg.egov.bg/segment/0009-000141")]
    public partial class ServiceApplicantReceiptDataMunicipalityAdministrationAdress : InformationObject<ServiceApplicantReceiptDataMunicipalityAdministrationAdress>
    {

        private string districtCodeField;

        private string districtNameField;

        private string municipalityCodeField;

        private string municipalityNameField;

        private string mayoraltyCodeField;

        private string mayoraltyField;

        private string areaCodeField;

        private string areaNameField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string DistrictCode
        {
            get
            {
                return this.districtCodeField;
            }
            set
            {
                if ((this.districtCodeField != null))
                {
                    if ((districtCodeField.Equals(value) != true))
                    {
                        this.districtCodeField = value;
                        this.OnPropertyChanged("DistrictCode");
                    }
                }
                else
                {
                    this.districtCodeField = value;
                    this.OnPropertyChanged("DistrictCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string DistrictName
        {
            get
            {
                return this.districtNameField;
            }
            set
            {
                if ((this.districtNameField != null))
                {
                    if ((districtNameField.Equals(value) != true))
                    {
                        this.districtNameField = value;
                        this.OnPropertyChanged("DistrictName");
                    }
                }
                else
                {
                    this.districtNameField = value;
                    this.OnPropertyChanged("DistrictName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string MunicipalityCode
        {
            get
            {
                return this.municipalityCodeField;
            }
            set
            {
                if ((this.municipalityCodeField != null))
                {
                    if ((municipalityCodeField.Equals(value) != true))
                    {
                        this.municipalityCodeField = value;
                        this.OnPropertyChanged("MunicipalityCode");
                    }
                }
                else
                {
                    this.municipalityCodeField = value;
                    this.OnPropertyChanged("MunicipalityCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string MunicipalityName
        {
            get
            {
                return this.municipalityNameField;
            }
            set
            {
                if ((this.municipalityNameField != null))
                {
                    if ((municipalityNameField.Equals(value) != true))
                    {
                        this.municipalityNameField = value;
                        this.OnPropertyChanged("MunicipalityName");
                    }
                }
                else
                {
                    this.municipalityNameField = value;
                    this.OnPropertyChanged("MunicipalityName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string MayoraltyCode
        {
            get
            {
                return this.mayoraltyCodeField;
            }
            set
            {
                if ((this.mayoraltyCodeField != null))
                {
                    if ((mayoraltyCodeField.Equals(value) != true))
                    {
                        this.mayoraltyCodeField = value;
                        this.OnPropertyChanged("MayoraltyCode");
                    }
                }
                else
                {
                    this.mayoraltyCodeField = value;
                    this.OnPropertyChanged("MayoraltyCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Mayoralty
        {
            get
            {
                return this.mayoraltyField;
            }
            set
            {
                if ((this.mayoraltyField != null))
                {
                    if ((mayoraltyField.Equals(value) != true))
                    {
                        this.mayoraltyField = value;
                        this.OnPropertyChanged("Mayoralty");
                    }
                }
                else
                {
                    this.mayoraltyField = value;
                    this.OnPropertyChanged("Mayoralty");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string AreaCode
        {
            get
            {
                return this.areaCodeField;
            }
            set
            {
                if ((this.areaCodeField != null))
                {
                    if ((areaCodeField.Equals(value) != true))
                    {
                        this.areaCodeField = value;
                        this.OnPropertyChanged("AreaCode");
                    }
                }
                else
                {
                    this.areaCodeField = value;
                    this.OnPropertyChanged("AreaCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string AreaName
        {
            get
            {
                return this.areaNameField;
            }
            set
            {
                if ((this.areaNameField != null))
                {
                    if ((areaNameField.Equals(value) != true))
                    {
                        this.areaNameField = value;
                        this.OnPropertyChanged("AreaName");
                    }
                }
                else
                {
                    this.areaNameField = value;
                    this.OnPropertyChanged("AreaName");
                }
            }
        }
    }
}
