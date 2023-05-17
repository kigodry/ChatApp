using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace ChatHello.Helpers
{
    public class NameValidator
    {
        public bool IsValidUsername(string username)
        {
            // Проверка на наличие недопустимых символов
            Regex regex = new Regex(@"^[a-zA-Z0-9_]+$"); // Разрешены только буквы (верхнего и нижнего регистра), цифры и символ подчеркивания
            if (!regex.IsMatch(username))
            {
                MessageBox.Show("Имя пользователя содержит недопустимые символы.");
                return false;
            }

            // Проверка длины имени пользователя
            if (username.Length < 3 || username.Length > 20)
            {
                MessageBox.Show("Имя пользователя должно содержать от 3 до 20 символов.");
                return false;
            }

            // Имя пользователя прошло все проверки
            return true;
        }
    }
}
