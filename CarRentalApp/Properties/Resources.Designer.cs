﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalApp.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CarRentalApp.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Are you Sure to Delete.
        /// </summary>
        internal static string Are_you_Sure_to_Delete {
            get {
                return ResourceManager.GetString("Are_you_Sure_to_Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap car_picture_default {
            get {
                object obj = ResourceManager.GetObject("car_picture_default", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client : {0} will be deleted !.
        /// </summary>
        internal static string Client__0__will_be_deleted {
            get {
                return ResourceManager.GetString("Client____0__will_be_deleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} have {1} Rents can&apos;t be deleted{2} Delete Rents first.
        /// </summary>
        internal static string Client__0__have__1__Rents_can_t_be_deleted_2__Delete_Rents_first {
            get {
                return ResourceManager.GetString("Client__0__have__1__Rents_can_t_be_deleted_2__Delete_Rents_first", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are You sure to delete this client ?.
        /// </summary>
        internal static string client_delete_confirm {
            get {
                return ResourceManager.GetString("client_delete_confirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database Error.
        /// </summary>
        internal static string database_Error {
            get {
                return ResourceManager.GetString("database_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Have {1} rent(s) delete them first !.
        /// </summary>
        internal static string Have_Rents_Delete_Them_First {
            get {
                return ResourceManager.GetString("Have_Rents_Delete_Them_First", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unauthorized delete action.
        /// </summary>
        internal static string Unauthorized_delete_action {
            get {
                return ResourceManager.GetString("Unauthorized_delete_action", resourceCulture);
            }
        }
    }
}
