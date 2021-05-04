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

namespace DialogsPasswordBox
{
    /// <summary>
    /// Логика взаимодействия для PasswordChange.xaml
    /// </summary>
    public partial class PasswordChange : Window
    {
        public PasswordChange()
        {
            InitializeComponent();
           
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            (Owner.FindName("passwordBox") as PasswordBox).Password = PassBox2.Password;
            Close();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                PassBox1.Focus();
                PassBox1.Password = (Owner.FindName("passwordBox") as PasswordBox).Password;
                PassBox2.Password = (Owner.FindName("passwordBox") as PasswordBox).Password;
            }
        }




        private void PassBox2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PassBox1.Password != PassBox2.Password)
                Ok.IsEnabled = false;
            else
                Ok.IsEnabled = true;
        }

        private void PassBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PassBox1.Password != PassBox2.Password)
                Ok.IsEnabled = false;
            else
                Ok.IsEnabled = true;
        }
    }
}
