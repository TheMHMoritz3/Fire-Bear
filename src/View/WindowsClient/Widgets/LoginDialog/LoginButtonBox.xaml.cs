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

namespace WindowsClient.Widgets.LoginDialog
{
    /// <summary>
    /// Interaction logic for LoginButtonBox.xaml
    /// </summary>
    public partial class LoginButtonBox : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginButtonBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Is called, when LoginButton is Triggered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onLoginClicked(object sender, RoutedEventArgs e)
        {
            LoginClicked(sender, e);
        }

        /// <summary>
        /// Is called, when CancelButton is Triggered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void onCancelClicked(object sender, RoutedEventArgs e)
        {
            CancelClicked(sender, e);
        }

        /// <summary>
        /// Event to push the click of the LoginButton to every needed Process
        /// </summary>
        public event EventHandler LoginClicked;
        /// <summary>
        /// Event to push the click of the CancelButton to every needed Process
        /// </summary>
        public event EventHandler CancelClicked;
    }
}
