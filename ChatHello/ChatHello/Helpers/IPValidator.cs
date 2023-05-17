using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatHello.Helpers
{
    public class IPValidator
    {
        internal bool IsValidUsername(string username)
        {
            // Проверка на наличие недопустимых символов
            if (!IsValidIpAddress(username))
            {
                MessageBox.Show("Неверный IP-адрес.");
                return false;
            }

            // Имя пользователя прошло все проверки
            return true;
        }

        internal bool IsValidIpAddress(string ipAddress)
        {
            // Проверка на правильный формат IP-адреса
            IPAddress parsedIpAddress;
            if (!IPAddress.TryParse(ipAddress, out parsedIpAddress))
            {
                return false;
            }

            // Проверка на формат IPv4
            if (parsedIpAddress.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
            {
                return false;
            }

            // IP-адрес прошел все проверки
            return true;
        }
    }
}
