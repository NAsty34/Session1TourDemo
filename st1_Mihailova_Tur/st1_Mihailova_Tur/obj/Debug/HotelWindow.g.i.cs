﻿#pragma checksum "..\..\HotelWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F841A50E26BA9AE417B400010EFC7DC05264B305DCC0FA26625BBD902B6C77E6"
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
    /// HotelWindow
    /// </summary>
    public partial class HotelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateHotel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveHotel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListHotel;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userElementsPage;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel buttonPagination;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NumberPage;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPage;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountPages;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\HotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountRow;
        
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
            System.Uri resourceLocater = new System.Uri("/st1_Mihailova_Tur;component/hotelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HotelWindow.xaml"
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
            
            #line 23 "..\..\HotelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CreateHotel = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\HotelWindow.xaml"
            this.CreateHotel.Click += new System.Windows.RoutedEventHandler(this.CreateHotel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RemoveHotel = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\HotelWindow.xaml"
            this.RemoveHotel.Click += new System.Windows.RoutedEventHandler(this.RemoveHotel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListHotel = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.userElementsPage = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\HotelWindow.xaml"
            this.userElementsPage.SelectionChanged += new System.Windows.RoutedEventHandler(this.ElementsPage_Selection);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonPagination = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            
            #line 51 "..\..\HotelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FirstPage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 52 "..\..\HotelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Last_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.NumberPage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.NextPage = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\HotelWindow.xaml"
            this.NextPage.Click += new System.Windows.RoutedEventHandler(this.Next_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 55 "..\..\HotelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LastPage_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.CountPages = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.CountRow = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 40 "..\..\HotelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateHotel_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

