﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITMO.ADOCourse.Lab05.DataBindingSimple.Ex02.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=FILIPPS\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True" +
            "")]
        public string NorthwindConnectionString {
            get {
                return ((string)(this["NorthwindConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\filma\\OneDrive\\Deskt" +
            "op\\ITMO.ADOCourse\\ITMO.ADOCourse.Lab05.DataBindingComplex.Ex03\\Lab05.DBLocalNort" +
            "hwind.mdf;User ID=ItmoPractice;Password=123456789")]
        public string Lab05_DBLocalNorthwindConnectionString {
            get {
                return ((string)(this["Lab05_DBLocalNorthwindConnectionString"]));
            }
        }
    }
}