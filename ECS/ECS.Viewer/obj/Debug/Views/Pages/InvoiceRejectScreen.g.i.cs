﻿#pragma checksum "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6D1F94AF55B7DBECF57F2FC3EFA893BAE9F836F12A768FE124125C5AD107B11"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using ECS.Core.ViewModels.Viewer;
using ECS.Viewer.Views.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ECS.Viewer.Views.Pages {
    
    
    /// <summary>
    /// InvoiceRejectScreen
    /// </summary>
    public partial class InvoiceRejectScreen : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Begin;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker End;
        
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
            System.Uri resourceLocater = new System.Uri("/ECS.Viewer;component/views/pages/invoicerejectscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
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
            this.Begin = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.End = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            
            #line 56 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 80 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 104 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 130 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 154 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchKeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 191 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.PageKeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 221 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PageLeftButtonClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 223 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PageRightButtonClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 230 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 249 "..\..\..\..\Views\Pages\InvoiceRejectScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExportClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

