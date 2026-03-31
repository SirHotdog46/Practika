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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        //private void btnLog_Click(object sender, RoutedEventArgs e)
        //{
        //    var currentuser = App.Context.User
        //        .FirstOrDefault(p => p.Login == tbLog.Text && p.Password == passBox.Password);

        //    if (currentuser != null)
        //    {
        //        App.CurrentUser = currentuser;

        //        NavigationService.Navigate(new Pages.ProductPage(currentuser.Role.Name));
        //    }
        //    else
        //    {
        //        MessageBox.Show("Неверный логин");
        //    }
        //}

        //private void btnGuest_Click(object sender, RoutedEventArgs e)
        //{
        //    //App.CurrentUser = new User();

        //    //App.CurrentUser.FIO = "Неизвестно";
        //    //App.CurrentUser.Role.Name = "Гость";


        //    NavigationService.Navigate(new Pages.ProductPage("Гость"));
        //}
    }
}
