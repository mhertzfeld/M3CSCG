﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M3CSCG.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("M3CSCG.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to @Class.
        /// </summary>
        internal static string Parameter_Class {
            get {
                return ResourceManager.GetString("Parameter_Class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Contents.
        /// </summary>
        internal static string Parameter_Contents {
            get {
                return ResourceManager.GetString("Parameter_Contents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @FieldName.
        /// </summary>
        internal static string Parameter_FieldName {
            get {
                return ResourceManager.GetString("Parameter_FieldName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Initialize.
        /// </summary>
        internal static string Parameter_Initialize {
            get {
                return ResourceManager.GetString("Parameter_Initialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @InterfaceName.
        /// </summary>
        internal static string Parameter_InterfaceName {
            get {
                return ResourceManager.GetString("Parameter_InterfaceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Name.
        /// </summary>
        internal static string Parameter_Name {
            get {
                return ResourceManager.GetString("Parameter_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @NameSpace.
        /// </summary>
        internal static string Parameter_NameSpace {
            get {
                return ResourceManager.GetString("Parameter_NameSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Properties.
        /// </summary>
        internal static string Parameter_Properties {
            get {
                return ResourceManager.GetString("Parameter_Properties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Property.
        /// </summary>
        internal static string Parameter_Property {
            get {
                return ResourceManager.GetString("Parameter_Property", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @SetFields.
        /// </summary>
        internal static string Parameter_SetFields {
            get {
                return ResourceManager.GetString("Parameter_SetFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Type.
        /// </summary>
        internal static string Parameter_Type {
            get {
                return ResourceManager.GetString("Parameter_Type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Lawson.M3.MvxSock;
        ///using MyClassLibrary;
        ///using System;
        ///
        ///
        ///namespace @NameSpace
        ///{
        ///    class @Class
        ///    {
        ///		//PROPERTIES
        ///@Properties
        ///
        ///		//INITIALIZE
        ///		public @Class()
        ///		{
        ///@Initialize
        ///		}
        ///
        ///		//METHODS
        ///		public void SetFields(ref SERVER_ID _ServerId)
        ///		{
        ///@SetFields
        ///		}
        ///    }
        ///}.
        /// </summary>
        internal static string Template_Class {
            get {
                return ResourceManager.GetString("Template_Class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public virtual @Type @Name { get; set; }.
        /// </summary>
        internal static string Template_ClassProperty {
            get {
                return ResourceManager.GetString("Template_ClassProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to             @Property = null;.
        /// </summary>
        internal static string Template_Initialize {
            get {
                return ResourceManager.GetString("Template_Initialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///
        ///namespace @NameSpace
        ///{
        ///    interface @InterfaceName
        ///    {
        ///@Contents
        ///	}
        ///}.
        /// </summary>
        internal static string Template_Interface {
            get {
                return ResourceManager.GetString("Template_Interface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         @Type @Name { get; set; }.
        /// </summary>
        internal static string Template_InterfaceProperty {
            get {
                return ResourceManager.GetString("Template_InterfaceProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to             @Property = MyDataConverter.ToDateTimeNullable(MvxSock.GetField(ref _ServerId, &quot;@FieldName&quot;), &quot;yyyyMMdd&quot;);.
        /// </summary>
        internal static string Template_SetField_Date {
            get {
                return ResourceManager.GetString("Template_SetField_Date", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to             @Property = MyDataConverter.ToDecimalNullable(MvxSock.GetField(ref _ServerId, &quot;@FieldName&quot;));.
        /// </summary>
        internal static string Template_SetField_Decimal {
            get {
                return ResourceManager.GetString("Template_SetField_Decimal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to             @Property = MyDataConverter.ToString(MvxSock.GetField(ref _ServerId, &quot;@FieldName&quot;));.
        /// </summary>
        internal static string Template_SetField_String {
            get {
                return ResourceManager.GetString("Template_SetField_String", resourceCulture);
            }
        }
    }
}