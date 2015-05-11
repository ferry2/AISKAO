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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ereg.egov.bg/segment/0009-000203")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ereg.egov.bg/segment/0009-000203", IsNullable = false)]
    public partial class HousingSavingsAccountAvailabilityReportApplication : InformationObject<HousingSavingsAccountAvailabilityReportApplication>
    {

        private ElectronicAdministrativeServiceHeader electronicAdministrativeServiceHeaderField;

        private ServiceTermType serviceTermTypeField;

        private bool serviceTermTypeFieldSpecified;

        private ServiceApplicantReceiptData serviceApplicantReceiptDataField;

        private List<object> attachedDocumentsField;

        private ElectronicAdministrativeServiceFooter electronicAdministrativeServiceFooterField;

        /// <summary>
        /// HousingSavingsAccountAvailabilityReportApplication class constructor
        /// </summary>
        public HousingSavingsAccountAvailabilityReportApplication()
        {
            this.electronicAdministrativeServiceFooterField = new ElectronicAdministrativeServiceFooter();
            this.attachedDocumentsField = new List<object>();
            this.serviceApplicantReceiptDataField = new ServiceApplicantReceiptData();
            this.electronicAdministrativeServiceHeaderField = new ElectronicAdministrativeServiceHeader();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, IsNullable = true)]
        public ElectronicAdministrativeServiceHeader ElectronicAdministrativeServiceHeader
        {
            get
            {
                return this.electronicAdministrativeServiceHeaderField;
            }
            set
            {
                if ((this.electronicAdministrativeServiceHeaderField != null))
                {
                    if ((electronicAdministrativeServiceHeaderField.Equals(value) != true))
                    {
                        this.electronicAdministrativeServiceHeaderField = value;
                        this.OnPropertyChanged("ElectronicAdministrativeServiceHeader");
                    }
                }
                else
                {
                    this.electronicAdministrativeServiceHeaderField = value;
                    this.OnPropertyChanged("ElectronicAdministrativeServiceHeader");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ServiceTermType ServiceTermType
        {
            get
            {
                return this.serviceTermTypeField;
            }
            set
            {
                if ((serviceTermTypeField.Equals(value) != true))
                {
                    this.serviceTermTypeField = value;
                    this.OnPropertyChanged("ServiceTermType");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceTermTypeSpecified
        {
            get
            {
                return this.serviceTermTypeFieldSpecified;
            }
            set
            {
                if ((serviceTermTypeFieldSpecified.Equals(value) != true))
                {
                    this.serviceTermTypeFieldSpecified = value;
                    this.OnPropertyChanged("ServiceTermTypeSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ServiceApplicantReceiptData ServiceApplicantReceiptData
        {
            get
            {
                return this.serviceApplicantReceiptDataField;
            }
            set
            {
                if ((this.serviceApplicantReceiptDataField != null))
                {
                    if ((serviceApplicantReceiptDataField.Equals(value) != true))
                    {
                        this.serviceApplicantReceiptDataField = value;
                        this.OnPropertyChanged("ServiceApplicantReceiptData");
                    }
                }
                else
                {
                    this.serviceApplicantReceiptDataField = value;
                    this.OnPropertyChanged("ServiceApplicantReceiptData");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(AttachedDocument), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AttachedXmlDocument", typeof(ElectronicDocumentXml), IsNullable = false)]
        public List<object> AttachedDocuments
        {
            get
            {
                return this.attachedDocumentsField;
            }
            set
            {
                if ((this.attachedDocumentsField != null))
                {
                    if ((attachedDocumentsField.Equals(value) != true))
                    {
                        this.attachedDocumentsField = value;
                        this.OnPropertyChanged("AttachedDocuments");
                    }
                }
                else
                {
                    this.attachedDocumentsField = value;
                    this.OnPropertyChanged("AttachedDocuments");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public ElectronicAdministrativeServiceFooter ElectronicAdministrativeServiceFooter
        {
            get
            {
                return this.electronicAdministrativeServiceFooterField;
            }
            set
            {
                if ((this.electronicAdministrativeServiceFooterField != null))
                {
                    if ((electronicAdministrativeServiceFooterField.Equals(value) != true))
                    {
                        this.electronicAdministrativeServiceFooterField = value;
                        this.OnPropertyChanged("ElectronicAdministrativeServiceFooter");
                    }
                }
                else
                {
                    this.electronicAdministrativeServiceFooterField = value;
                    this.OnPropertyChanged("ElectronicAdministrativeServiceFooter");
                }
            }
        }
    }
}
