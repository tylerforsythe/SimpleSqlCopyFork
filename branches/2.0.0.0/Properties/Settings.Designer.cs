﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.SqlCopy.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\sqlexpress;Initial Catalog=<source db name>;Integrated Security=Tru" +
            "e")]
        public string source {
            get {
                return ((string)(this["source"]));
            }
            set {
                this["source"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\sqlexpress;Initial Catalog=<destination db name>;Integrated Securit" +
            "y=True")]
        public string destination {
            get {
                return ((string)(this["destination"]));
            }
            set {
                this["destination"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int Timeout {
            get {
                return ((int)(this["Timeout"]));
            }
            set {
                this["Timeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int BatchSize {
            get {
                return ((int)(this["BatchSize"]));
            }
            set {
                this["BatchSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection sourcelist {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["sourcelist"]));
            }
            set {
                this["sourcelist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection destinationlist {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["destinationlist"]));
            }
            set {
                this["destinationlist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool KeepIdentity {
            get {
                return ((bool)(this["KeepIdentity"]));
            }
            set {
                this["KeepIdentity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool KeepNulls {
            get {
                return ((bool)(this["KeepNulls"]));
            }
            set {
                this["KeepNulls"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckConstraints {
            get {
                return ((bool)(this["CheckConstraints"]));
            }
            set {
                this["CheckConstraints"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FireTriggers {
            get {
                return ((bool)(this["FireTriggers"]));
            }
            set {
                this["FireTriggers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TableLock {
            get {
                return ((bool)(this["TableLock"]));
            }
            set {
                this["TableLock"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DeleteRows {
            get {
                return ((bool)(this["DeleteRows"]));
            }
            set {
                this["DeleteRows"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("exec sp_msforeachtable \'ALTER TABLE ? NOCHECK CONSTRAINT all\';\r\nexec sp_msforeach" +
            "table \'ALTER TABLE ? DISABLE TRIGGER all\';")]
        public string PreCopySql {
            get {
                return ((string)(this["PreCopySql"]));
            }
            set {
                this["PreCopySql"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("exec sp_msforeachtable \'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all\';\r\nexec sp_" +
            "msforeachtable \'ALTER TABLE ? ENABLE TRIGGER all\';")]
        public string PostCopySql {
            get {
                return ((string)(this["PostCopySql"]));
            }
            set {
                this["PostCopySql"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ThreadCount {
            get {
                return ((decimal)(this["ThreadCount"]));
            }
            set {
                this["ThreadCount"] = value;
            }
        }
    }
}
