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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/R-1100")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/R-1100", IsNullable=false)]
    public partial class CROZDealInfoCertificate : InformationObject<CROZDealInfoCertificate> {
        
        private DocumentTypeURI documentTypeURIField;
        
        private string documentTypeNameField;
        
        private DocumentURI documentURIField;
        
        private System.DateTime documentReceiptOrSigningDateField;
        
        private bool documentReceiptOrSigningDateFieldSpecified;
        
        private ElectronicServiceProviderBasicData electronicServiceProviderBasicDataField;
        
        private ElectronicServiceApplicant electronicServiceApplicantField;
        
        private CROZDealRegistrationEntryData cROZDealRegistrationEntryDataField;
        
        private List<CROZAmendmentOnDealRegistrationEntryBasicData> cROZAmendmentOnDealRegistrationEntryBasicDatasField;
        
        private string cROZInformationActualityDescriptionField;
        
        private CROZDealInfoCertificateOfficial officialField;
        
        private XMLDigitalSignature xMLDigitalSignatureField;
        
        /// <summary>
        /// CROZDealInfoCertificate class constructor
        /// </summary>
        public CROZDealInfoCertificate() {
            this.xMLDigitalSignatureField = new XMLDigitalSignature();
            this.officialField = new CROZDealInfoCertificateOfficial();
            this.cROZAmendmentOnDealRegistrationEntryBasicDatasField = new List<CROZAmendmentOnDealRegistrationEntryBasicData>();
            this.cROZDealRegistrationEntryDataField = new CROZDealRegistrationEntryData();
            this.electronicServiceApplicantField = new ElectronicServiceApplicant();
            this.electronicServiceProviderBasicDataField = new ElectronicServiceProviderBasicData();
            this.documentURIField = new DocumentURI();
            this.documentTypeURIField = new DocumentTypeURI();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DocumentTypeURI DocumentTypeURI {
            get {
                return this.documentTypeURIField;
            }
            set {
                if ((this.documentTypeURIField != null)) {
                    if ((documentTypeURIField.Equals(value) != true)) {
                        this.documentTypeURIField = value;
                        this.OnPropertyChanged("DocumentTypeURI");
                    }
                }
                else {
                    this.documentTypeURIField = value;
                    this.OnPropertyChanged("DocumentTypeURI");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DocumentTypeName {
            get {
                return this.documentTypeNameField;
            }
            set {
                if ((this.documentTypeNameField != null)) {
                    if ((documentTypeNameField.Equals(value) != true)) {
                        this.documentTypeNameField = value;
                        this.OnPropertyChanged("DocumentTypeName");
                    }
                }
                else {
                    this.documentTypeNameField = value;
                    this.OnPropertyChanged("DocumentTypeName");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DocumentURI DocumentURI {
            get {
                return this.documentURIField;
            }
            set {
                if ((this.documentURIField != null)) {
                    if ((documentURIField.Equals(value) != true)) {
                        this.documentURIField = value;
                        this.OnPropertyChanged("DocumentURI");
                    }
                }
                else {
                    this.documentURIField = value;
                    this.OnPropertyChanged("DocumentURI");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime DocumentReceiptOrSigningDate {
            get {
                return this.documentReceiptOrSigningDateField;
            }
            set {
                if ((documentReceiptOrSigningDateField.Equals(value) != true)) {
                    this.documentReceiptOrSigningDateField = value;
                    this.OnPropertyChanged("DocumentReceiptOrSigningDate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentReceiptOrSigningDateSpecified {
            get {
                return this.documentReceiptOrSigningDateFieldSpecified;
            }
            set {
                if ((documentReceiptOrSigningDateFieldSpecified.Equals(value) != true)) {
                    this.documentReceiptOrSigningDateFieldSpecified = value;
                    this.OnPropertyChanged("DocumentReceiptOrSigningDateSpecified");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public ElectronicServiceProviderBasicData ElectronicServiceProviderBasicData {
            get {
                return this.electronicServiceProviderBasicDataField;
            }
            set {
                if ((this.electronicServiceProviderBasicDataField != null)) {
                    if ((electronicServiceProviderBasicDataField.Equals(value) != true)) {
                        this.electronicServiceProviderBasicDataField = value;
                        this.OnPropertyChanged("ElectronicServiceProviderBasicData");
                    }
                }
                else {
                    this.electronicServiceProviderBasicDataField = value;
                    this.OnPropertyChanged("ElectronicServiceProviderBasicData");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ElectronicServiceApplicant ElectronicServiceApplicant {
            get {
                return this.electronicServiceApplicantField;
            }
            set {
                if ((this.electronicServiceApplicantField != null)) {
                    if ((electronicServiceApplicantField.Equals(value) != true)) {
                        this.electronicServiceApplicantField = value;
                        this.OnPropertyChanged("ElectronicServiceApplicant");
                    }
                }
                else {
                    this.electronicServiceApplicantField = value;
                    this.OnPropertyChanged("ElectronicServiceApplicant");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public CROZDealRegistrationEntryData CROZDealRegistrationEntryData {
            get {
                return this.cROZDealRegistrationEntryDataField;
            }
            set {
                if ((this.cROZDealRegistrationEntryDataField != null)) {
                    if ((cROZDealRegistrationEntryDataField.Equals(value) != true)) {
                        this.cROZDealRegistrationEntryDataField = value;
                        this.OnPropertyChanged("CROZDealRegistrationEntryData");
                    }
                }
                else {
                    this.cROZDealRegistrationEntryDataField = value;
                    this.OnPropertyChanged("CROZDealRegistrationEntryData");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=7)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<CROZAmendmentOnDealRegistrationEntryBasicData> CROZAmendmentOnDealRegistrationEntryBasicDatas {
            get {
                return this.cROZAmendmentOnDealRegistrationEntryBasicDatasField;
            }
            set {
                if ((this.cROZAmendmentOnDealRegistrationEntryBasicDatasField != null)) {
                    if ((cROZAmendmentOnDealRegistrationEntryBasicDatasField.Equals(value) != true)) {
                        this.cROZAmendmentOnDealRegistrationEntryBasicDatasField = value;
                        this.OnPropertyChanged("CROZAmendmentOnDealRegistrationEntryBasicDatas");
                    }
                }
                else {
                    this.cROZAmendmentOnDealRegistrationEntryBasicDatasField = value;
                    this.OnPropertyChanged("CROZAmendmentOnDealRegistrationEntryBasicDatas");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string CROZInformationActualityDescription {
            get {
                return this.cROZInformationActualityDescriptionField;
            }
            set {
                if ((this.cROZInformationActualityDescriptionField != null)) {
                    if ((cROZInformationActualityDescriptionField.Equals(value) != true)) {
                        this.cROZInformationActualityDescriptionField = value;
                        this.OnPropertyChanged("CROZInformationActualityDescription");
                    }
                }
                else {
                    this.cROZInformationActualityDescriptionField = value;
                    this.OnPropertyChanged("CROZInformationActualityDescription");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public CROZDealInfoCertificateOfficial Official {
            get {
                return this.officialField;
            }
            set {
                if ((this.officialField != null)) {
                    if ((officialField.Equals(value) != true)) {
                        this.officialField = value;
                        this.OnPropertyChanged("Official");
                    }
                }
                else {
                    this.officialField = value;
                    this.OnPropertyChanged("Official");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public XMLDigitalSignature XMLDigitalSignature {
            get {
                return this.xMLDigitalSignatureField;
            }
            set {
                if ((this.xMLDigitalSignatureField != null)) {
                    if ((xMLDigitalSignatureField.Equals(value) != true)) {
                        this.xMLDigitalSignatureField = value;
                        this.OnPropertyChanged("XMLDigitalSignature");
                    }
                }
                else {
                    this.xMLDigitalSignatureField = value;
                    this.OnPropertyChanged("XMLDigitalSignature");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ereg.egov.bg/segment/R-1100")]
    public partial class CROZDealInfoCertificateOfficial : InformationObject<CROZDealInfoCertificateOfficial> {
        
        private object itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("ForeignCitizenNames", typeof(ForeignCitizenNames), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("PersonNames", typeof(PersonNames), Order=0)]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                if ((this.itemField != null)) {
                    if ((itemField.Equals(value) != true)) {
                        this.itemField = value;
                        this.OnPropertyChanged("Item");
                    }
                }
                else {
                    this.itemField = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }
    }
}
