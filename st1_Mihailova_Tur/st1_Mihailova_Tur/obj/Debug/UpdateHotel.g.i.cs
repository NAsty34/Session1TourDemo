﻿#pragma checksum "..\..\UpdateHotel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F313F66B3F7A310B19614536C0EB69929C9784167B3DE9288E1DA71C59F374B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using st1_Mihailova_Tur;


namespace st1_Mihailova_Tur {
    
    
    /// <summary>
    /// UpdateHotel
    /// </summary>
    public partial class UpdateHotel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\UpdateHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HeaderWindow;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UpdateHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameHotel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UpdateHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountStars;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\UpdateHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionHotel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UpdateHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListCountry;
        
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
            System.Uri resourceLocater = new System.Uri("/st1_Mihailova_Tur;component/updatehotel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdateHotel.xaml"
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
            
            #line 18 "..\..\UpdateHotel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HeaderWindow = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.NameHotel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CountStars = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\UpdateHotel.xaml"
            this.CountStars.SelectionChanged += new System.Windows.RoutedEventHandler(this.CountStars_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DescriptionHotel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ListCountry = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 39 "..\..\UpdateHotel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

