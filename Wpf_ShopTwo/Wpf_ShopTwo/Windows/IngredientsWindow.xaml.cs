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
using Wpf_ShopTwo.ADO;
using System.IO;

namespace Wpf_ShopTwo.Windows
{
    /// <summary>
    /// Логика взаимодействия для IngredientsWindow.xaml
    /// </summary>
    public partial class IngredientsWindow : Window
    {
        public byte[] Image { get; set; }
        private List<Item> items = new List<Item>();
        private List<Item> ingredients = new List<Item>();
        public IngredientsWindow()
        {
            InitializeComponent();
            var list = App.Connection.Item.ToList();
            foreach (var prod in list)
            {
                items.Add(prod);
            }
        }
        private void SelectBtn_Click(object sender, RoutedEventArgs e)
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
            Item item = new Item()
            {
                Title = tbTitle.Text,
                Group = int.Parse(tbGroup.Text),
                Count = int.Parse(tbCount.Text),
                Image = Image
            };
            App.Connection.Item.Add(item);
            App.Connection.SaveChanges();
            foreach (var i in items)
            {
                ingredients.Add(i);
            }
            IngredientsList.ItemsSource = ingredients;
            MessageBox.Show("Item added");
        }


    }
}
