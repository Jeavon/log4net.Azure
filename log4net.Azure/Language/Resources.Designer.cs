﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace log4net.Appender.Umbraco.Language {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("log4net.Appender.Umbraco.Language.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Azure ConnectionString not specified.
        /// </summary>
        internal static string AzureConnectionStringNotSpecified {
            get {
                return ResourceManager.GetString("AzureConnectionStringNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container name not specified.
        /// </summary>
        internal static string ContainerNameNotSpecified {
            get {
                return ResourceManager.GetString("ContainerNameNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory name not specified.
        /// </summary>
        internal static string DirectoryNameNotSpecified {
            get {
                return ResourceManager.GetString("DirectoryNameNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to not supported {0} for {1}.
        /// </summary>
        internal static string ElasticTableEntity_GetEntityProperty_not_supported__0__for__1_ {
            get {
                return ResourceManager.GetString("ElasticTableEntity_GetEntityProperty_not_supported__0__for__1_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to not supported {0}.
        /// </summary>
        internal static string ElasticTableEntity_GetType_not_supported__0_ {
            get {
                return ResourceManager.GetString("ElasticTableEntity_GetType_not_supported__0_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Queue name not specified.
        /// </summary>
        internal static string QueueNameNotSpecified {
            get {
                return ResourceManager.GetString("QueueNameNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table name not specified.
        /// </summary>
        internal static string TableNameNotSpecified {
            get {
                return ResourceManager.GetString("TableNameNotSpecified", resourceCulture);
            }
        }
    }
}
