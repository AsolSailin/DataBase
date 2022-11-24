using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf_ShopTwo.ADO;
using Microsoft.Win32;

namespace Wpf_ShopTwo.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AddIngredientsBtn_Click(object sender, RoutedEventArgs e)
        {
            IngredientsWindow ingredientsWindow = new IngredientsWindow();
            ingredientsWindow.Show();
            this.Close();
        }

        private void RecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow recipe = new RecipeWindow();
            recipe.Show();
            this.Close();
        }

        private void CookBtn_Click(object sender, RoutedEventArgs e)
        {
            CookingWindow cook = new CookingWindow();
            cook.Show();
            this.Close();
        }
    }
}
