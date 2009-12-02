﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace O2.ImportExport.OunceLabs.Ozasmt_OunceV6
{
    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AssessmentRun
    {
        /// <remarks/>
        public AssessmentStats AssessmentStats { get; set; }

        /// <remarks/>
        public AssessmentRunAssessmentConfig AssessmentConfig { get; set; }

        /// <remarks/>
        [XmlArrayItem("FileIndex", IsNullable = false)]
        public AssessmentRunFileIndex[] FileIndeces { get; set; }

        /// <remarks/>
        [XmlArrayItem("StringIndex", IsNullable = false)]
        public AssessmentRunStringIndex[] StringIndeces { get; set; }

        /// <remarks/>
        public AssessmentRunAssessment Assessment { get; set; }

        /// <remarks/>
        [XmlArrayItem("Message", IsNullable = false)]
        public AssessmentRunMessage[] Messages { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AssessmentStats
    {
        /// <remarks/>
        [XmlElement("VulnType")]
        public AssessmentStatsVulnType[] VulnType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint duration { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint date { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint language_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_files { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_findings { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint error_status { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint line_total { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public decimal vkloc { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public decimal vdensity { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public decimal max_vkloc { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public decimal max_vdensity { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_high_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_high_high_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_high_med_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_high_low_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_med_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_med_high_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_med_med_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_med_low_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_low_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_low_high_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_low_med_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_low_low_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_call_sites { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_call_sites_not_vulnerable { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string owner_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string owner_name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint class_total { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint method_total { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_call_sites_informational { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentStatsVulnType
    {
        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_high_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_med_finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint total_low_finding { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class CallInvocation
    {
        /// <remarks/>
        [XmlElement("CallInvocation")]
        public CallInvocation[] CallInvocation1 { get; set; }

        /// <remarks/>
        [XmlText]
        public string[] Text { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint fn_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint sig_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint cxt_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint mn_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint cn_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint line_number { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint column_number { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint trace_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint ordinal { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint taint_propagation { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunAssessmentConfig
    {
        /// <remarks/>
        public AssessmentRunAssessmentConfigApplication Application { get; set; }

        /// <remarks/>
        public AssessmentRunAssessmentConfigProject Project { get; set; }

        /// <remarks/>
        [XmlElement("File")]
        public AssessmentRunAssessmentConfigFile[] File { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint analysis_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint assessment_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool stop_on_error { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunAssessmentConfigApplication
    {
        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string path { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunAssessmentConfigProject
    {
        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string path { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunAssessmentConfigFile
    {
        /// <remarks/>
        [XmlAttribute]
        public string path { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunFileIndex
    {
        /// <remarks/>
        [XmlAttribute]
        public uint id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string value { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunStringIndex
    {
        /// <remarks/>
        [XmlAttribute]
        public uint id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string value { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunAssessment
    {
        /// <remarks/>
        public AssessmentStats AssessmentStats { get; set; }

        /// <remarks/>
        [XmlElement("Assessment")]
        public Assessment[] Assessment { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string owner_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string owner_name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string assessee_name { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Assessment
    {
        /// <remarks/>
        public AssessmentStats AssessmentStats { get; set; }

        /// <remarks/>
        [XmlElement("AssessmentFile")]
        public AssessmentAssessmentFile[] AssessmentFile { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string owner_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string owner_name { get; set; }

        [XmlAttribute]
        public string assessee_name { get; set; }        
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentAssessmentFile
    {
        /// <remarks/>
        public AssessmentStats AssessmentStats { get; set; }

        /// <remarks/>
        [XmlElement("Finding")]
        public AssessmentAssessmentFileFinding[] Finding { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string filename { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte error_status { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte last_modified_time { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentAssessmentFileFinding
    {
        /// <remarks/>
        [XmlArrayItem("CallInvocation", IsNullable = false)]
        public CallInvocation[] Trace { get; set; }

        /// <remarks/>
        [XmlText]
        public string[] Text { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint record_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint line_number { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint column_number { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint actionobject_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte severity { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string context { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string vuln_name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string caller_name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte confidence { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string vuln_type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool exclude { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string project_name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint ordinal { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string property_ids { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string caller_name_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string cxt_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string project_name_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string vuln_name_id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string vuln_type_id { get; set; }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "2.0.50727.1432")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AssessmentRunMessage
    {
        /// <remarks/>
        [XmlAttribute]
        public uint id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public uint type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string message { get; set; }
    }
}