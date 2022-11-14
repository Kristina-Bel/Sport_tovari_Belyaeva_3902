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
using System.Windows.Threading;
using Sport_tovari_Belyaeva_3902.ApplicationData;
using Sport_tovari_Belyaeva_3902.PageAdmin;
using Sport_tovari_Belyaeva_3902.PageClient;

namespace Sport_tovari_Belyaeva_3902.Pagemain
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.modelOdb.User.FirstOrDefault(x => x.Login == Login.Text && x.Password == Password.Text);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.IDrole)
                    {
                        case 1:
                            AppFrame.frameMain.Navigate(new PageMenuAdmin());
                            MessageBox.Show("Здравствуйте, Администратор " + userObj.FIO + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;

                        case 2:
                            AppFrame.frameMain.Navigate(new PageSp());
                            MessageBox.Show("Здравствуйте, менеджер " + userObj.FIO + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        case 3:
                            AppFrame.frameMain.Navigate(new PageSp());
                            MessageBox.Show("Здравствуйте, клиент " + userObj.FIO + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message.ToString() + "Критическая работа приложения!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageCreateAcc());
        }

        private void gost_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageSp());
        }
    }
}
