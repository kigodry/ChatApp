using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using ChatHello.Helpers;


namespace ChatHello
{
    public partial class AdminChatPage : Page
    {
        private List<Message> messages = new List<Message>();

        public AdminChatPage()
        {
            InitializeComponent();

            sendButton.Click += SendButton_Click;
            viewLogsButton.Click += ViewLogsButton_Click;
        }

        private void ViewLogsButton_Click(object sender, RoutedEventArgs e)
        {
            if (messages.Any())
            {
                ChatLogsWindow logsWindow = new ChatLogsWindow(messages);
                logsWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Нет доступных логов чата.");
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string messageText = messageBox.Text;
            if (!string.IsNullOrWhiteSpace(messageText))
            {
                Message message = new Message
                {
                    Sender = "Админ",
                    Text = messageText
                };

                messages.Add(message);
                messageBox.Clear();
                UpdateMessageListBox();
            }
        }

        private void UpdateMessageListBox()
        {
            messageListBox.ItemsSource = null;
            messageListBox.ItemsSource = messages;
            messageListBox.ScrollIntoView(messages.LastOrDefault());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
            Window.GetWindow(this)?.Close();
        }
    }
}
