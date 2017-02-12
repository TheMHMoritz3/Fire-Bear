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
using Model.Manager.States;
using Model.Data;

namespace WindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Is Triggered if Close Action is Triggered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// On Login Clicked is a LoginData Creted and a new Connection is Created
        /// TODO: Create new Connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_LoginClick(object sender, RoutedEventArgs e)
        {
            LoginDialog.LoginDialog loginDialog = new LoginDialog.LoginDialog();
            loginDialog.ShowDialog();
            if(loginDialog.getStatusManager().getState()==1)
            {
                _CurrentLoginData = loginDialog.getLogin();
            }
        }

        /// <summary>
        /// The Current Login Data
        /// </summary>
        private LoginData _CurrentLoginData = null;
    }
}
