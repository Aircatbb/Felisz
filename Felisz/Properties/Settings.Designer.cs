﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Felisz.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("server=s27.tarhely.com;uid=cbbsseu_sqlaccess;pwd=^DJ5H-B^!wBmXe+-;database=cbbsse" +
            "u_felisz_main;Character Set=utf8")]
        public string felisz_db_ConnectionString {
            get {
                return ((string)(this["felisz_db_ConnectionString"]));
            }
            set {
                this["felisz_db_ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.hrportal.hu/rss/hirek.xml")]
        public string RSSUrl {
            get {
                return ((string)(this["RSSUrl"]));
            }
            set {
                this["RSSUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://net.jogtar.hu/jogszabaly?docid=A1200001.TV")]
        public string MTUrl {
            get {
                return ((string)(this["MTUrl"]));
            }
            set {
                this["MTUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("+36 30 650 5947")]
        public string ügyfélSzolgTel {
            get {
                return ((string)(this["ügyfélSzolgTel"]));
            }
            set {
                this["ügyfélSzolgTel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("balazs.bognar@hotmail.com")]
        public string ügyfélSzolgEmail {
            get {
                return ((string)(this["ügyfélSzolgEmail"]));
            }
            set {
                this["ügyfélSzolgEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("server=s27.tarhely.com;uid=cbbsseu_XXX;pwd=YYY;database=cbbsseu_ZZZ;Character Set" +
            "=utf8")]
        public string cég_db_ConnectionString {
            get {
                return ((string)(this["cég_db_ConnectionString"]));
            }
            set {
                this["cég_db_ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("admin")]
        public string utolsóFelhasználó {
            get {
                return ((string)(this["utolsóFelhasználó"]));
            }
            set {
                this["utolsóFelhasználó"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int bejelentkezésiKisérlet {
            get {
                return ((int)(this["bejelentkezésiKisérlet"]));
            }
            set {
                this["bejelentkezésiKisérlet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double jelszóÉrvényesség {
            get {
                return ((double)(this["jelszóÉrvényesség"]));
            }
            set {
                this["jelszóÉrvényesség"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AIzaSyDbfd28AxL8tBKWUrmEOHaBh9e3D-NGQnY")]
        public string GoogleMapsAPI {
            get {
                return ((string)(this["GoogleMapsAPI"]));
            }
            set {
                this["GoogleMapsAPI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TTSEngedélyezve {
            get {
                return ((bool)(this["TTSEngedélyezve"]));
            }
            set {
                this["TTSEngedélyezve"] = value;
            }
        }
    }
}
