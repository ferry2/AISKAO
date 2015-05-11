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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/R-1087")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/R-1087", IsNullable=true)]
    public partial class CROZConsignmentRegistrationEntryData : CROZRegistrationEntryBasicData, System.ComponentModel.INotifyPropertyChanged {
        
        private CROZRegistrationEntryDateForNewManagerInvitationsData cROZRegistrationEntryDateForNewManagerInvitationsDataField;
        
        private int cROZConsignmentEntryAmendmentsCountField;
        
        private bool cROZConsignmentEntryAmendmentsCountFieldSpecified;
        
        private List<CROZConsignmentRegistrationEntryParticipantData> cROZConsignmentRegistrationEntryParticipantDatasField;
        
        /// <summary>
        /// CROZConsignmentRegistrationEntryData class constructor
        /// </summary>
        public CROZConsignmentRegistrationEntryData() {
            this.cROZConsignmentRegistrationEntryParticipantDatasField = new List<CROZConsignmentRegistrationEntryParticipantData>();
            this.cROZRegistrationEntryDateForNewManagerInvitationsDataField = new CROZRegistrationEntryDateForNewManagerInvitationsData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CROZRegistrationEntryDateForNewManagerInvitationsData CROZRegistrationEntryDateForNewManagerInvitationsData {
            get {
                return this.cROZRegistrationEntryDateForNewManagerInvitationsDataField;
            }
            set {
                if ((this.cROZRegistrationEntryDateForNewManagerInvitationsDataField != null)) {
                    if ((cROZRegistrationEntryDateForNewManagerInvitationsDataField.Equals(value) != true)) {
                        this.cROZRegistrationEntryDateForNewManagerInvitationsDataField = value;
                        this.OnPropertyChanged("CROZRegistrationEntryDateForNewManagerInvitationsData");
                    }
                }
                else {
                    this.cROZRegistrationEntryDateForNewManagerInvitationsDataField = value;
                    this.OnPropertyChanged("CROZRegistrationEntryDateForNewManagerInvitationsData");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int CROZConsignmentEntryAmendmentsCount {
            get {
                return this.cROZConsignmentEntryAmendmentsCountField;
            }
            set {
                if ((cROZConsignmentEntryAmendmentsCountField.Equals(value) != true)) {
                    this.cROZConsignmentEntryAmendmentsCountField = value;
                    this.OnPropertyChanged("CROZConsignmentEntryAmendmentsCount");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CROZConsignmentEntryAmendmentsCountSpecified {
            get {
                return this.cROZConsignmentEntryAmendmentsCountFieldSpecified;
            }
            set {
                if ((cROZConsignmentEntryAmendmentsCountFieldSpecified.Equals(value) != true)) {
                    this.cROZConsignmentEntryAmendmentsCountFieldSpecified = value;
                    this.OnPropertyChanged("CROZConsignmentEntryAmendmentsCountSpecified");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<CROZConsignmentRegistrationEntryParticipantData> CROZConsignmentRegistrationEntryParticipantDatas {
            get {
                return this.cROZConsignmentRegistrationEntryParticipantDatasField;
            }
            set {
                if ((this.cROZConsignmentRegistrationEntryParticipantDatasField != null)) {
                    if ((cROZConsignmentRegistrationEntryParticipantDatasField.Equals(value) != true)) {
                        this.cROZConsignmentRegistrationEntryParticipantDatasField = value;
                        this.OnPropertyChanged("CROZConsignmentRegistrationEntryParticipantDatas");
                    }
                }
                else {
                    this.cROZConsignmentRegistrationEntryParticipantDatasField = value;
                    this.OnPropertyChanged("CROZConsignmentRegistrationEntryParticipantDatas");
                }
            }
        }
    }
}
