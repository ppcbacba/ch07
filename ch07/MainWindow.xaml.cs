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
using ch07.Examples;

namespace ch07
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private RadioButton rb = null;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rb = e.Source as RadioButton;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (rb == null)
            {
                MessageBox.Show("请先选择一个例子", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            string content = rb.Content.ToString();
            Window w = null;
            switch (content)
            {
                case "HelloWorld":
                    w = new HelloWorldWindow();
                    break;
            }
            if (w == null) return;
            w.Owner = this;
            w.ShowDialog();
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
//            var login=new LoginWindow();
//            login.ShowDialog();
//            this.Title = "欢迎您, " + login.UserName;
        
        }
    }
}
