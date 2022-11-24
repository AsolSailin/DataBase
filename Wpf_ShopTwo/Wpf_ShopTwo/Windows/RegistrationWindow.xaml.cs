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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text != "" && tbPassword.Text != "" && tbName.Text != "" && tbRole.Text != "")
            {
                User newUser = new User()
                {
                    Name = tbName.Text,
                    Role_Id = int.Parse(tbRole.Text)
                };
                Account newAccount = new Account()
                {
                    Login = tbLogin.Text,
                    Password = tbPassword.Text
                };

                newUser.Account.Add(newAccount);
                App.Connection.User.Add(newUser);
                App.Connection.Account.Add(newAccount);
                App.Connection.SaveChanges();
                MessageBox.Show("Registration is successfull");
            }
            else
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show(); ;
            this.Close();
        }
    }
}
