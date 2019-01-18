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

namespace ch07.Examples
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public string UserName { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            userNameTextBox.Text = string.Empty;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            switch (btn.Content.ToString())
            {
                case "确定":
                    this.UserName = userNameTextBox.Text;
                    this.Close();
                    break;
                case "取消":
                    App.Current.Shutdown();
                    break;


            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(this.UserName)==true)
            {
                App.Current.Shutdown();
            }

        }
    }
}
