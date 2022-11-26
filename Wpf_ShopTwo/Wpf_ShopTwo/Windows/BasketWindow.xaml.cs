using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace Wpf_ShopTwo.Windows
{
    /// <summary>
    /// Логика взаимодействия для BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {
        private Account account;
        private List<Item> items = new List<Item>();
        private List<Basket> basket { get; set; }
        public BasketWindow()
        {
            InitializeComponent();
        }

        public BasketWindow(Account acc)
        {
            this.account = acc;
            InitializeComponent();
            List.ItemsSource = App.Connection.Item.ToList();
            basket = App.Connection.Basket.Where(x => x.User_Id == account.User_Id).ToList();
            foreach (var prod in basket)
            {
                items.Add(App.Connection.Item.Where(x => x.Id == prod.Id).FirstOrDefault());
            }
            BasketList.ItemsSource = items;
        }

        private void Select(object sender, SelectionChangedEventArgs e)
        {
            var item = List.SelectedItem as Item;

            Basket newBasket = new Basket()
            {
                User_Id = account.User_Id,
                Item = item,
            };

            App.Connection.Basket.Add(newBasket);
            App.Connection.SaveChanges();
            items.Add(item);
            BasketList.Items.Refresh();
        }
    }
}
