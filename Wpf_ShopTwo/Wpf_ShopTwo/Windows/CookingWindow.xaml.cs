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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using Wpf_ShopTwo.ADO;
using System.IO;

namespace Wpf_ShopTwo.Windows
{
    /// <summary>
    /// Логика взаимодействия для CookingWindow.xaml
    /// </summary>
    public partial class CookingWindow : Window
    {
        public byte[] Image { get; set; }
        public CookingWindow()
        {
            InitializeComponent();
            RecipeComboBox.ItemsSource = App.Connection.Recipe.ToList();
            IngredientsComboBox.ItemsSource = App.Connection.Item.ToList();
        }

        private void CookBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeComboBox.Text == "")
            {
                MessageBox.Show("Give a name to a product!");
                return;
            }

            if (RecipeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose recipe!");
                return;
            }

            foreach (Item item in NeededIngredientsList.Items)
            {
                if (item.Count == 0)
                {
                    MessageBox.Show("Not enough ingridients!");
                    return;
                }
            }

            foreach (Item item in NeededIngredientsList.Items)
            {
                item.Count--;
            }

            Product newProduct = new Product()
            {
                Title = tbTitle.Text,
                Recipe = RecipeComboBox.SelectedItem as Recipe,

            };
            App.Connection.Product.Add(newProduct);
            App.Connection.SaveChanges();

            MessageBox.Show("Successfull product adding!");
        }
        private void SelectRecipe(object sender, SelectionChangedEventArgs e)
        {
            List<Item> items = new List<Item>();
            var recipe = RecipeComboBox.SelectedItem as Recipe;
            var itemRecipe = recipe.Item_Recipe;
            foreach (var item in itemRecipe)
            {
                items.Add(App.Connection.Item.FirstOrDefault(x => x.Id == item.Item_Id));
            }
            NeededIngredientsList.ItemsSource = items;
        }
        private void SelectIngredient(object sender, SelectionChangedEventArgs e)
        {
            IngredientsList.Items.Add(IngredientsComboBox.SelectedItem);
        }
        /*private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var btnSelect = sender as Button;
                var dialog = new OpenFileDialog();
                if (dialog.ShowDialog() != null)
                {
                    Image = File.ReadAllBytes(dialog.FileName);
                }
                btnSelect.Background = Brushes.Green;
            }
            catch
            {
                MessageBox.Show("Only images!");
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product()
            {
                Title = tbTitle.Text,
                Image = Image,
                Recipe = RecipeComboBox.SelectedItem as Recipe
            };
            App.Connection.Product.Add(product);
            App.Connection.SaveChanges();
            MessageBox.Show("Product added");
        }*/
    }
}
