﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A541F62CB352C04573C8E50430A4B14F65383E5792658092A1406BB45082813"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GMap.NET.WindowsPresentation;
using Lab3;
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


namespace Lab3 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Maps;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GMap.NET.WindowsPresentation.GMapControl Map;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox OList;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createra;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton createrb;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton findrb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox objfind;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button finder;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearpoints;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab3;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Maps = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Map = ((GMap.NET.WindowsPresentation.GMapControl)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.Map.Loaded += new System.Windows.RoutedEventHandler(this.MapLoaded);
            
            #line default
            #line hidden
            
            #line 14 "..\..\MainWindow.xaml"
            this.Map.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Map_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 14 "..\..\MainWindow.xaml"
            this.Map.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Map_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.combox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.combox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Combox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.OList = ((System.Windows.Controls.ListBox)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.OList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OList_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.OList.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OList_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.createra = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.createra.Click += new System.Windows.RoutedEventHandler(this.Createra_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.createrb = ((System.Windows.Controls.RadioButton)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.createrb.Checked += new System.Windows.RoutedEventHandler(this.Createrb_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.findrb = ((System.Windows.Controls.RadioButton)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.findrb.Checked += new System.Windows.RoutedEventHandler(this.Findrb_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.objfind = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.finder = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.finder.Click += new System.Windows.RoutedEventHandler(this.Finder_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.clearpoints = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.clearpoints.Click += new System.Windows.RoutedEventHandler(this.Clearpoints_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
