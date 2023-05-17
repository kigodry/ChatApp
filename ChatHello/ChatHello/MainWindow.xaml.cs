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
using ChatHello.Helpers;

namespace ChatHello
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateChatButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UserName.Text;
            NameValidator nameValidator = new NameValidator();
            if (!nameValidator.IsValidUsername(username))
            {
                return;
            }

            string ipAddress = IPAdress.Text;
            IPValidator ipValidator = new IPValidator();
            if (!ipValidator.IsValidIpAddress(ipAddress))
            {
                // IP-адрес недопустим, выведите сообщение об ошибке
                MessageBox.Show("Неверный IP-адрес.");
                return;
            }

            // Переход на страницу AdminChatPage.xaml
            AdminChatPage adminChatPage = new AdminChatPage();

            // Открытие нового окна с AdminChatPage
            Window newWindow = new Window();
            newWindow.Content = adminChatPage;
            newWindow.Show();

            // Закрытие текущего окна
            Window.GetWindow(this).Close();

        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UserName.Text;
            NameValidator nameValidator = new NameValidator();
            if (!nameValidator.IsValidUsername(username))
            {
                return;
            }

            string ipAddress = IPAdress.Text;
            IPValidator ipValidator = new IPValidator();
            if (!ipValidator.IsValidIpAddress(ipAddress))
            {
                // IP-адрес недопустим, выведите сообщение об ошибке
                MessageBox.Show("Неверный IP-адрес.");
                return;
            }

            // Переход на страницу UserChatPage.xaml
            UserChatPage userChatPage = new UserChatPage();
            Window newWindow = new Window();
            newWindow.Content = userChatPage;
            newWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}