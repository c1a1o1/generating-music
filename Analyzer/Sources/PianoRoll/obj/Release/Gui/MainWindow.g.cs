﻿#pragma checksum "..\..\..\Gui\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3F6376A428D5BC2A8218734D2D9CEA5E13929B00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace PianoRoll {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid VerticalGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid HorizontalGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenFileButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveFileButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BatchConvertButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ImageGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PianoRollImage;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ChannelButtonsGrid;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Gui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label OpenedFilePathLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/PianoRoll;component/gui/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gui\MainWindow.xaml"
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
            
            #line 7 "..\..\..\Gui\MainWindow.xaml"
            ((PianoRoll.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\Gui\MainWindow.xaml"
            ((PianoRoll.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\Gui\MainWindow.xaml"
            ((PianoRoll.MainWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VerticalGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.HorizontalGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.OpenFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Gui\MainWindow.xaml"
            this.OpenFileButton.Click += new System.Windows.RoutedEventHandler(this.OpenFileButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SaveFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Gui\MainWindow.xaml"
            this.SaveFileButton.Click += new System.Windows.RoutedEventHandler(this.SaveFileButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BatchConvertButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Gui\MainWindow.xaml"
            this.BatchConvertButton.Click += new System.Windows.RoutedEventHandler(this.BatchConvertButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PlayButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Gui\MainWindow.xaml"
            this.PlayButton.Click += new System.Windows.RoutedEventHandler(this.PlayButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.StopButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Gui\MainWindow.xaml"
            this.StopButton.Click += new System.Windows.RoutedEventHandler(this.StopButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Gui\MainWindow.xaml"
            this.SettingsButton.Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ImageGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.PianoRollImage = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.ChannelButtonsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.OpenedFilePathLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

