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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/R-1083")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/R-1083", IsNullable=true)]
    public partial class CROZConsignmentRegistrationEntryParticipantData : CROZRegistrationEntryParticipantBasicData, System.ComponentModel.INotifyPropertyChanged {
        
        private CROZRegistrationEntryDatesForExecutionEntriesData cROZRegistrationEntryDatesForExecutionEntriesDataField;
        
        private CROZRegistrationEntryDatesForLeaveOfExecutionEntriesData cROZRegistrationEntryDatesForLeaveOfExecutionEntriesDataField;
        
        private CROZRegistrationEntryDatesForErasureAgreeementEntriesData cROZRegistrationEntryDatesForErasureAgreeementEntriesDataField;
        
        /// <summary>
        /// CROZConsignmentRegistrationEntryParticipantData class constructor
        /// </summary>
        public CROZConsignmentRegistrationEntryParticipantData() {
            this.cROZRegistrationEntryDatesForErasureAgreeementEntriesDataField = new CROZRegistrationEntryDatesForErasureAgreeementEntriesData();
            this.cROZRegistrationEntryDatesForLeaveOfExecutionEntriesDataField = new CROZRegistrationEntryDatesForLeaveOfExecutionEntriesData();
            this.cROZRegistrationEntryDatesForExecutionEntriesDataField = new CROZRegistrationEntryDatesForExecutionEntriesData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CROZRegistrationEntryDatesForExecutionEntriesData CROZRegistrationEntryDatesForExecutionEntriesData {
            get {
                return this.cROZRegistrationEntryDatesForExecutionEntriesDataField;
            }
            set {
                if ((this.cROZRegistrationEntryDatesForExecutionEntriesDataField != null)) {
                    if ((cROZRegistrationEntryDatesForExecutionEntriesDataField.Equals(value) != true)) {
                        this.cROZRegistrationEntryDatesForExecutionEntriesDataField = value;
                        this.OnPropertyChanged("CROZRegistrationEntryDatesForExecutionEntriesData");
                    }
                }
                else {
                    this.cROZRegistrationEntryDatesForExecutionEntriesDataField = value;
                    this.OnPropertyChanged("CROZRegistrationEntryDatesForExecutionEntriesData");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public CROZRegistrationEntryDatesForLeaveOfExecutionEntriesData CROZRegistrationEntryDatesForLeaveOfExecutionEntriesData {
            get {
                return this.cROZRegistrationEntryDatesForLeaveOfExecutionEntriesDataField;
            }
            set {
                if ((this.cROZRegistrationEntryDatesForLeaveOfExecutionEntriesDataField != null)) {
                    if ((cROZRegistrationEntryDatesForLeaveOfExecutionEntriesDataField.Equals(value) != true)) {
                        this.cROZRegistrationEntryDatesForLeaveOfExecutionEntriesDataField = value;
                        this.OnPropertyChanged("CROZRegistrationEntryDatesForLeaveOfExecutionEntriesData");
                    }
                }
                else {
                    this.cROZRegistrationEntryDatesForLeaveOfExecutionEntriesDataField = value;
                    this.OnPropertyChanged("CROZRegistrationEntryDatesForLeaveOfExecutionEntriesData");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public CROZRegistrationEntryDatesForErasureAgreeementEntriesData CROZRegistrationEntryDatesForErasureAgreeementEntriesData {
            get {
                return this.cROZRegistrationEntryDatesForErasureAgreeementEntriesDataField;
            }
            set {
                if ((this.cROZRegistrationEntryDatesForErasureAgreeementEntriesDataField != null)) {
                    if ((cROZRegistrationEntryDatesForErasureAgreeementEntriesDataField.Equals(value) != true)) {
                        this.cROZRegistrationEntryDatesForErasureAgreeementEntriesDataField = value;
                        this.OnPropertyChanged("CROZRegistrationEntryDatesForErasureAgreeementEntriesData");
                    }
                }
                else {
                    this.cROZRegistrationEntryDatesForErasureAgreeementEntriesDataField = value;
                    this.OnPropertyChanged("CROZRegistrationEntryDatesForErasureAgreeementEntriesData");
                }
            }
        }
    }
}
