﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueToque.XsdToClasses.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BlueToque.XsdToClasses.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///{XsdToClasses} */.
        /// </summary>
        internal static string Configuration_EndDelimeter {
            get {
                return ResourceManager.GetString("Configuration_EndDelimeter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}
        ///{1}
        ///{2}
        ///
        ///.
        /// </summary>
        internal static string Configuration_FormatString {
            get {
                return ResourceManager.GetString("Configuration_FormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* {XsdToClasses}
        ///.
        /// </summary>
        internal static string Configuration_StartDelimeter {
            get {
                return ResourceManager.GetString("Configuration_StartDelimeter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #error Couldn&apos;t generate code.
        ////*
        ///{0}
        ///*/.
        /// </summary>
        internal static string CustomTool_GeneralError {
            get {
                return ResourceManager.GetString("CustomTool_GeneralError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tool {0} does not contain the required {1} attribute..
        /// </summary>
        internal static string CustomTool_ToolRequiredAttributeMissing {
            get {
                return ResourceManager.GetString("CustomTool_ToolRequiredAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .Generated.
        /// </summary>
        internal static string GeneratedCodeExtension {
            get {
                return ResourceManager.GetString("GeneratedCodeExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Workaround for bug http://lab.msdn.microsoft.com/productfeedback/viewfeedback.aspx?feedbackid=d457a36e-0ce8-4368-9a27-92762860d8e1.
        /// </summary>
        internal static string Message_1591 {
            get {
                return ResourceManager.GetString("Message_1591", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma warning disable 1591.
        /// </summary>
        internal static string Pragma_1591_Disable {
            get {
                return ResourceManager.GetString("Pragma_1591_Disable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma warning restore 1591.
        /// </summary>
        internal static string Pragma_1591_Enable {
            get {
                return ResourceManager.GetString("Pragma_1591_Enable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; must have the &apos;{1}&apos; attribute..
        /// </summary>
        internal static string Tool_AttributeMissing {
            get {
                return ResourceManager.GetString("Tool_AttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .genConfig.xml.
        /// </summary>
        internal static string ToolConfigExtension {
            get {
                return ResourceManager.GetString("ToolConfigExtension", resourceCulture);
            }
        }
        
        internal static System.Drawing.Icon Toque {
            get {
                object obj = ResourceManager.GetObject("Toque", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This source code was auto-generated by {0}, Version {1}..
        /// </summary>
        internal static string VersionComment {
            get {
                return ResourceManager.GetString("VersionComment", resourceCulture);
            }
        }
    }
}
