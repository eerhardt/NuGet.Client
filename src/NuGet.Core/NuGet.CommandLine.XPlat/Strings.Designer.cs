﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.CommandLine.XPlat {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Strings() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.CommandLine.XPlat.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to NuGet Command Line.
        /// </summary>
        internal static string App_FullName {
            get {
                return ResourceManager.GetString("App_FullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Committing restore....
        /// </summary>
        internal static string Log_Committing {
            get {
                return ResourceManager.GetString("Log_Committing", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Found project root directory: {0}..
        /// </summary>
        internal static string Log_FoundProjectRoot {
            get {
                return ResourceManager.GetString("Log_FoundProjectRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Loaded project {0} from {1}..
        /// </summary>
        internal static string Log_LoadedProject {
            get {
                return ResourceManager.GetString("Log_LoadedProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Reading project file {0}..
        /// </summary>
        internal static string Log_ReadingProject {
            get {
                return ResourceManager.GetString("Log_ReadingProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restore completed in {0}ms..
        /// </summary>
        internal static string Log_RestoreComplete {
            get {
                return ResourceManager.GetString("Log_RestoreComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restore failed in {0}ms..
        /// </summary>
        internal static string Log_RestoreFailed {
            get {
                return ResourceManager.GetString("Log_RestoreFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Running non-parallel restore..
        /// </summary>
        internal static string Log_RunningNonParallelRestore {
            get {
                return ResourceManager.GetString("Log_RunningNonParallelRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Running restore with {0} concurrent jobs..
        /// </summary>
        internal static string Log_RunningParallelRestore {
            get {
                return ResourceManager.GetString("Log_RunningParallelRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Using packages directory: {0}..
        /// </summary>
        internal static string Log_UsingPackagesDirectory {
            get {
                return ResourceManager.GetString("Log_UsingPackagesDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to List of projects and project folders to restore. Each value can be: a path to a project.json or global.json file, or a folder to recursively search for project.json files..
        /// </summary>
        internal static string Restore_Arg_ProjectName_Description {
            get {
                return ResourceManager.GetString("Restore_Arg_ProjectName_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restores packages for a project and writes a lock file..
        /// </summary>
        internal static string Restore_Description {
            get {
                return ResourceManager.GetString("Restore_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Disables restoring multiple projects in parallel..
        /// </summary>
        internal static string Restore_Switch_DisableParallel_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_DisableParallel_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A list of packages sources to use as a fallback..
        /// </summary>
        internal static string Restore_Switch_Fallback_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_Fallback_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Directory to install packages in..
        /// </summary>
        internal static string Restore_Switch_Packages_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_Packages_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to List of runtime identifiers to restore for..
        /// </summary>
        internal static string Restore_Switch_Runtime_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_Runtime_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specifies a NuGet package source to use during the restore..
        /// </summary>
        internal static string Restore_Switch_Source_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_Source_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The verbosity of logging to use. Allowed values: Debug, Verbose, Information, Warning, Error..
        /// </summary>
        internal static string Switch_Verbosity {
            get {
                return ResourceManager.GetString("Switch_Verbosity", resourceCulture);
            }
        }
    }
}
