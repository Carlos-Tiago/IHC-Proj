<<<<<<< HEAD
﻿#pragma checksum "..\..\NewEvent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87182FABF26BE8D037FB75DCC0759A59128D5A21"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    /// NewEvent
    /// </summary>
    public partial class NewEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BottonPopUpLogout;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectOption;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb1;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb2;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb3;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb4;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb5;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\NewEvent.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/newevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewEvent.xaml"
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
            
            #line 40 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AccountClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BottonPopUpLogout = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\NewEvent.xaml"
            this.BottonPopUpLogout.Click += new System.Windows.RoutedEventHandler(this.ButtonPopUpLogout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.selectOption = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\NewEvent.xaml"
            this.selectOption.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.selectOption_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbb1 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 5:
            this.cbb2 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 6:
            this.cbb3 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 7:
            this.cbb4 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.cbb5 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            
            #line 70 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MemberAdded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\NewEvent.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\NewEvent.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 86 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HomeItemSelected);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 100 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewMemberButton);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 101 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RenewMemberButton);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 115 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EventClick);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 116 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReunionsClick);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 118 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SponsorsClick);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 124 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TestItemSelected);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 130 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.GitHubItemSelected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

=======
﻿#pragma checksum "..\..\NewEvent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21166CD60FC4212F0B46A34D34B1888F600CEEF0"
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
    /// NewEvent
    /// </summary>
    public partial class NewEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BottonPopUpLogout;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectOption;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb1;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb2;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb3;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb4;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbb5;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHour;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMonth;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDay;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EventAdded;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\NewEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\NewEvent.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/newevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewEvent.xaml"
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
            
            #line 8 "..\..\NewEvent.xaml"
            ((WpfApp1.NewEvent)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.AddEvent);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 40 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AccountClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BottonPopUpLogout = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\NewEvent.xaml"
            this.BottonPopUpLogout.Click += new System.Windows.RoutedEventHandler(this.ButtonPopUpLogout_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.selectOption = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\NewEvent.xaml"
            this.selectOption.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.selectOption_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbb1 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 7:
            this.cbb2 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.cbb3 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.cbb4 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 10:
            this.cbb5 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 11:
            this.txtHour = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtMonth = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.txtDay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.EventAdded = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\NewEvent.xaml"
            this.EventAdded.Click += new System.Windows.RoutedEventHandler(this.MemberAdded);
            
            #line default
            #line hidden
            return;
            case 15:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 17:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\NewEvent.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\NewEvent.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 87 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HomeItemSelected);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 101 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewMemberButton);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 102 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RenewMemberButton);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 116 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EventClick);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 117 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReunionsClick);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 119 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SponsorsClick);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 125 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TestItemSelected);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 131 "..\..\NewEvent.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.GitHubItemSelected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

>>>>>>> 12a3bdba4d06c27ac25af621d355a91232c68e7b
