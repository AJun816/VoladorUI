﻿#pragma checksum "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63C4890025A28F0FADF57D7A73434466B6947A57D8DA2774A6FDF0A6FC8FA4BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Volador.Toolkit.Wpf.UserControls.Loading.LoadingMask;


namespace Volador.Toolkit.Wpf.UserControls.Loading.LoadingMask {
    
    
    /// <summary>
    /// LoadingMask
    /// </summary>
    public partial class LoadingMask : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 103 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid container;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform rt;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borOrange;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borGreen;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borRed;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borCustom;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoadingText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Volador.Toolkit.Wpf;component/usercontrols/loading/loadingmask/loadingmask.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControls\Loading\LoadingMask\LoadingMask.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.container = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.rt = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 3:
            this.borOrange = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.borGreen = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.borRed = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.borCustom = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.LoadingText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

