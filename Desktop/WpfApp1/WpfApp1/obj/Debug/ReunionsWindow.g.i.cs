﻿#pragma checksum "..\..\ReunionsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E5D41A890B60388B36360ABAA8B427916754FC56"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// ReunionsWindow
    /// </summary>
    public partial class ReunionsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\ReunionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BottonPopUpLogout;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\ReunionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\ReunionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ReunionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/reunionswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReunionsWindow.xaml"
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
            
            #line 40 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AccountClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BottonPopUpLogout = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\ReunionsWindow.xaml"
            this.BottonPopUpLogout.Click += new System.Windows.RoutedEventHandler(this.ButtonPopUpLogout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 64 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewReunionClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\ReunionsWindow.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\ReunionsWindow.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 82 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HomeItemSelected);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 96 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewMemberButton);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RenewMemberButton);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 111 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EventClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 112 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReunionsClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 114 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SponsorsClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 120 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TestItemSelected);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 126 "..\..\ReunionsWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.GitHubItemSelected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

