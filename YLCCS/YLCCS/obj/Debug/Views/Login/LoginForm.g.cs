﻿#pragma checksum "D:\Products\YLCCS\YLCCS\Views\Login\LoginForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "152BA9100CA2CAC6BBE7C1596ADED959"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.235
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using YLCCS.Controls;


namespace YLCCS.LoginUI {
    
    
    public partial class LoginForm : System.Windows.Controls.StackPanel {
        
        internal YLCCS.Controls.BusyIndicator busyIndicator;
        
        internal YLCCS.Controls.CustomDataForm loginForm;
        
        internal System.Windows.Controls.Button loginButton;
        
        internal System.Windows.Controls.Button loginCancel;
        
        internal System.Windows.Controls.HyperlinkButton registerNow;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/YLCCS;component/Views/Login/LoginForm.xaml", System.UriKind.Relative));
            this.busyIndicator = ((YLCCS.Controls.BusyIndicator)(this.FindName("busyIndicator")));
            this.loginForm = ((YLCCS.Controls.CustomDataForm)(this.FindName("loginForm")));
            this.loginButton = ((System.Windows.Controls.Button)(this.FindName("loginButton")));
            this.loginCancel = ((System.Windows.Controls.Button)(this.FindName("loginCancel")));
            this.registerNow = ((System.Windows.Controls.HyperlinkButton)(this.FindName("registerNow")));
        }
    }
}

