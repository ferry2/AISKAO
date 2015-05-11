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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000200")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000200", IsNullable=true)]
    public partial class MunicipalPropertyActIdentifier : InformationObject<MunicipalPropertyActIdentifier> {
        
        private string numberField;
        
        private System.DateTime issueDateField;
        
        private bool issueDateFieldSpecified;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField != null)) {
                    if ((numberField.Equals(value) != true)) {
                        this.numberField = value;
                        this.OnPropertyChanged("Number");
                    }
                }
                else {
                    this.numberField = value;
                    this.OnPropertyChanged("Number");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime IssueDate {
            get {
                return this.issueDateField;
            }
            set {
                if ((issueDateField.Equals(value) != true)) {
                    this.issueDateField = value;
                    this.OnPropertyChanged("IssueDate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IssueDateSpecified {
            get {
                return this.issueDateFieldSpecified;
            }
            set {
                if ((issueDateFieldSpecified.Equals(value) != true)) {
                    this.issueDateFieldSpecified = value;
                    this.OnPropertyChanged("IssueDateSpecified");
                }
            }
        }
    }
}
