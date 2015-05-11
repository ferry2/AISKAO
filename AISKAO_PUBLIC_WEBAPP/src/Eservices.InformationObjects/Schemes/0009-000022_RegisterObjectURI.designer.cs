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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000022")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000022", IsNullable=true)]
    public partial class RegisterObjectURI : InformationObject<RegisterObjectURI> {
        
        private string registerIndexField;
        
        private string batchNumberField;
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string RegisterIndex {
            get {
                return this.registerIndexField;
            }
            set {
                if ((this.registerIndexField != null)) {
                    if ((registerIndexField.Equals(value) != true)) {
                        this.registerIndexField = value;
                        this.OnPropertyChanged("RegisterIndex");
                    }
                }
                else {
                    this.registerIndexField = value;
                    this.OnPropertyChanged("RegisterIndex");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=1)]
        public string BatchNumber {
            get {
                return this.batchNumberField;
            }
            set {
                if ((this.batchNumberField != null)) {
                    if ((batchNumberField.Equals(value) != true)) {
                        this.batchNumberField = value;
                        this.OnPropertyChanged("BatchNumber");
                    }
                }
                else {
                    this.batchNumberField = value;
                    this.OnPropertyChanged("BatchNumber");
                }
            }
        }
    }
}
