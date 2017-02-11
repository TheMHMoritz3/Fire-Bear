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

namespace WindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_LoginClick(object sender, RoutedEventArgs e)
        {
            LoginDialog.LoginDialog loginDialog = new LoginDialog.LoginDialog();
            loginDialog.ShowDialog();
        }
    }
}
