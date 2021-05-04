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

namespace DialogsPasswordBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        PasswordChange win1 = new PasswordChange();

        private string password = "qwerty";
        public string Password { get => password; set => password = value; }

        public MainWindow()
        {
            InitializeComponent();
            passwordBox.Focus();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            win1.Owner = this;


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            win1.ShowDialog();
            Password = passwordBox.Password;
            button1.IsEnabled = true;
            passwordBox.Focus();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == Password)
                button1.IsEnabled = true;
            else
                button1.IsEnabled = false;

        }


    }
}
