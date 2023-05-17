using ChatHello.Helpers;
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

namespace ChatHello
{

    public partial class ChatLogsWindow : Window
    {

        private List<Message> messages;

        public ChatLogsWindow(List<Message> messages)
        {
            InitializeComponent();
            this.messages = messages;
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            dataGrid.ItemsSource = messages;
        }
    }
}
