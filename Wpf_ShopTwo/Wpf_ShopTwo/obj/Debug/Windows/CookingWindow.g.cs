#pragma checksum "..\..\..\Windows\CookingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21454587D42F4E5BB14EEB73C050DFBC4A4166D136BEB3E9C9523AA7315BC6AB"
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
using Wpf_ShopTwo.Windows;


namespace Wpf_ShopTwo.Windows {
    
    
    /// <summary>
    /// CookingWindow
    /// </summary>
    public partial class CookingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Windows\CookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox NeededIngredientsList;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows\CookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTitle;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Windows\CookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RecipeComboBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\CookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IngredientsComboBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Windows\CookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox IngredientsList;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_ShopTwo;component/windows/cookingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\CookingWindow.xaml"
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
            this.NeededIngredientsList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.tbTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RecipeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\Windows\CookingWindow.xaml"
            this.RecipeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectRecipe);
            
            #line default
            #line hidden
            return;
            case 4:
            this.IngredientsComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\..\Windows\CookingWindow.xaml"
            this.IngredientsComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectIngredient);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IngredientsList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            
            #line 72 "..\..\..\Windows\CookingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CookBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

