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
using System.IO;
using Wpf_Shop.ADO;

namespace Wpf_Shop.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public byte[] Image { get; set; }
        public AdminWindow()
        {
            InitializeComponent();
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

        private void AddBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Item item = new Item()
            {
                Title = tbTitle.Text,
                Group = int.Parse(tbGroup.Text),
                Info = tbInfo.Text,
                Image = Image
            };
            App.Connection.Item.Add(item);
            App.Connection.SaveChanges();
            MessageBox.Show("Item added");
        }
    }
}
