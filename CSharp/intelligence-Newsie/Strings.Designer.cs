﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Newsie {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Newsie.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Hmm... I did not understand that {0}. Rephrase your message and try again..
        /// </summary>
        internal static string FallbackIntentMessage {
            get {
                return ResourceManager.GetString("FallbackIntentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Full Story.
        /// </summary>
        internal static string FullStoryString {
            get {
                return ResourceManager.GetString("FullStoryString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi {0}! What would you like to read about? You can either pick a category below or just type the topic {1}. I&apos;ll do my best to fetch the latest and the most important stories from across the web {2}, powered by Bing News..
        /// </summary>
        internal static string GreetOnDemand {
            get {
                return ResourceManager.GetString("GreetOnDemand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi {0}! I&apos;m Newsie. I&apos;m here to super-charge the way you read the daily news {1} by generating on-demand smart summaries of any article you&apos;re interested in..
        /// </summary>
        internal static string GreetWithHiMessage {
            get {
                return ResourceManager.GetString("GreetWithHiMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I&apos;ll pull in some news about {0} category {1}!.
        /// </summary>
        internal static string NewsCategoryTypeMessage {
            get {
                return ResourceManager.GetString("NewsCategoryTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hmm... I&apos;m having trouble finding news for this term {0}. Rephrase your message and try again..
        /// </summary>
        internal static string NewsSearchErrorMessage {
            get {
                return ResourceManager.GetString("NewsSearchErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here you go {0}.
        /// </summary>
        internal static string NewsTopicTypeMessage {
            get {
                return ResourceManager.GetString("NewsTopicTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Say &quot;Hi&quot; if you would like to get statred {0}..
        /// </summary>
        internal static string StartGreetingMessage {
            get {
                return ResourceManager.GetString("StartGreetingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hmm, I&apos;m sorry. I could not summarize the article {0}..
        /// </summary>
        internal static string SummaryErrorMessage {
            get {
                return ResourceManager.GetString("SummaryErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SUMMARY.
        /// </summary>
        internal static string SummaryString {
            get {
                return ResourceManager.GetString("SummaryString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hold on! I&apos;ll be back in a jiffy {0}!.
        /// </summary>
        internal static string SummaryWaitMessage {
            get {
                return ResourceManager.GetString("SummaryWaitMessage", resourceCulture);
            }
        }
    }
}
