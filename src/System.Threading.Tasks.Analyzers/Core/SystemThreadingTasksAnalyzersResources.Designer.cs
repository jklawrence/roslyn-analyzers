﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Threading.Tasks.Analyzers {
    using System;
    using System.Reflection;
    
    
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
    internal class SystemThreadingTasksAnalyzersResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SystemThreadingTasksAnalyzersResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Threading.Tasks.Analyzers.SystemThreadingTasksAnalyzersResources", typeof(SystemThreadingTasksAnalyzersResources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Reliability.
        /// </summary>
        internal static string CategoryReliability {
            get {
                return ResourceManager.GetString("CategoryReliability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not create tasks unless you are using one of the overloads that takes a TaskScheduler. The default is to schedule on TaskScheduler.Current, which would lead to deadlocks. Either use TaskScheduler.Default to schedule on the thread pool, or explicitly pass TaskScheduler.Current to make your intentions clear..
        /// </summary>
        internal static string DoNotCreateTasksWithoutPassingATaskSchedulerDescription {
            get {
                return ResourceManager.GetString("DoNotCreateTasksWithoutPassingATaskSchedulerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not create tasks without passing a TaskScheduler.
        /// </summary>
        internal static string DoNotCreateTasksWithoutPassingATaskSchedulerMessage {
            get {
                return ResourceManager.GetString("DoNotCreateTasksWithoutPassingATaskSchedulerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not create tasks without passing a TaskScheduler.
        /// </summary>
        internal static string DoNotCreateTasksWithoutPassingATaskSchedulerTitle {
            get {
                return ResourceManager.GetString("DoNotCreateTasksWithoutPassingATaskSchedulerTitle", resourceCulture);
            }
        }
    }
}
