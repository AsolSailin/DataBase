using Microsoft.Win32;
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
using System.IO;
using System.Text.RegularExpressions;
using Wpf_ShopTwo.ADO;
using System.Windows.Media.Media3D;

namespace Wpf_ShopTwo.Windows
{
    /// <summary>
    /// Логика взаимодействия для RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public byte[] Image { get; set; }
        public RecipeWindow()
        {
            InitializeComponent();
            IngredientsComboBox.ItemsSource = App.Connection.Item.ToList();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            Recipe newRecipe = new Recipe()
            {
                Title = tbTitle.Text,
                Info = IngredientsList.ToString()
            };

            App.Connection.Recipe.Add(newRecipe);

            foreach (Item item in IngredientsList.Items)
            {
                App.Connection.Item_Recipe.Add(new Item_Recipe()
                {
                    Item = item,
                    Recipe = newRecipe
                });
            }

            App.Connection.SaveChanges();
            MessageBox.Show("Successfully added new recept!");
        }
        private void Select(object sender, SelectionChangedEventArgs e)
        {
            IngredientsList.Items.Add(IngredientsComboBox.SelectedItem);
        }
    }
}
