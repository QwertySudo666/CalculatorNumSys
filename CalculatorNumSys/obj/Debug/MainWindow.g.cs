// Updated by XamlIntelliSenseFileGenerator 13.08.2020 21:52:54
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC30AAF2D4380724B745D898844D64FBBF537D092D56C27E10F1D2BD2F8B9CCD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CalculatorNumSys;
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


namespace CalculatorNumSys
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        /// <summary>
        /// LayoutGrid Name Field
        /// </summary>

#line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Grid LayoutGrid;

#line default
#line hidden


#line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sysnumList;

#line default
#line hidden


#line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sysnumList_2;

#line default
#line hidden


#line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNum;

#line default
#line hidden


#line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox secondNum;

#line default
#line hidden


#line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Plus;

#line default
#line hidden


#line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minus;

#line default
#line hidden


#line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Mn;

#line default
#line hidden


#line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dil;

#line default
#line hidden


#line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fromDecTo;

#line default
#line hidden

        /// <summary>
        /// Answer Name Field
        /// </summary>

#line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Label Answer;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CalculatorNumSys;component/mainwindow.xaml", System.UriKind.Relative);

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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.LayoutGrid = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this.sysnumList = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 3:
                    this.sysnumList_2 = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 4:
                    this.firstNum = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.secondNum = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.Plus = ((System.Windows.Controls.Button)(target));

#line 51 "..\..\MainWindow.xaml"
                    this.Plus.Click += new System.Windows.RoutedEventHandler(this.Plus_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.Minus = ((System.Windows.Controls.Button)(target));

#line 52 "..\..\MainWindow.xaml"
                    this.Minus.Click += new System.Windows.RoutedEventHandler(this.Minus_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.Mn = ((System.Windows.Controls.Button)(target));

#line 53 "..\..\MainWindow.xaml"
                    this.Mn.Click += new System.Windows.RoutedEventHandler(this.Mn_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.Dil = ((System.Windows.Controls.Button)(target));

#line 54 "..\..\MainWindow.xaml"
                    this.Dil.Click += new System.Windows.RoutedEventHandler(this.Dil_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.Perevod = ((System.Windows.Controls.Button)(target));

#line 55 "..\..\MainWindow.xaml"
                    this.Perevod.Click += new System.Windows.RoutedEventHandler(this.Perevod_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.Test = ((System.Windows.Controls.Button)(target));

#line 56 "..\..\MainWindow.xaml"
                    this.Test.Click += new System.Windows.RoutedEventHandler(this.Test_Click);

#line default
#line hidden
                    return;
                case 12:
                    this.fromDecTo = ((System.Windows.Controls.Button)(target));

#line 57 "..\..\MainWindow.xaml"
                    this.fromDecTo.Click += new System.Windows.RoutedEventHandler(this.fromDecTo_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.Answer = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

