﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YLCCS.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class RegistrationDataResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RegistrationDataResources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("YLCCS.Web.Resources.RegistrationDataResources", typeof(RegistrationDataResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Email 的本地化字符串。
        /// </summary>
        public static string EmailLabel {
            get {
                return ResourceManager.GetString("EmailLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 How do you want your name to be displayed in the application 的本地化字符串。
        /// </summary>
        public static string FriendlyNameDescription {
            get {
                return ResourceManager.GetString("FriendlyNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Friendly name 的本地化字符串。
        /// </summary>
        public static string FriendlyNameLabel {
            get {
                return ResourceManager.GetString("FriendlyNameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Confirm password 的本地化字符串。
        /// </summary>
        public static string PasswordConfirmationLabel {
            get {
                return ResourceManager.GetString("PasswordConfirmationLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The password must be 7 characters long and must contain at least one special character e.g. @ or # 的本地化字符串。
        /// </summary>
        public static string PasswordDescription {
            get {
                return ResourceManager.GetString("PasswordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Password 的本地化字符串。
        /// </summary>
        public static string PasswordLabel {
            get {
                return ResourceManager.GetString("PasswordLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Security answer 的本地化字符串。
        /// </summary>
        public static string SecurityAnswerLabel {
            get {
                return ResourceManager.GetString("SecurityAnswerLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Security question 的本地化字符串。
        /// </summary>
        public static string SecurityQuestionLabel {
            get {
                return ResourceManager.GetString("SecurityQuestionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 User name 的本地化字符串。
        /// </summary>
        public static string UserNameLabel {
            get {
                return ResourceManager.GetString("UserNameLabel", resourceCulture);
            }
        }
    }
}
