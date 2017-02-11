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
using WindowsClient.States.LoginDialog;

namespace WindowsClient.LoginDialog
{
    /// <summary>
    /// Interaction logic for LoginDialog.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginDialog()
        {
            InitializeComponent();
            generateDialogState();
        }

        /// <summary>
        /// Generates the LoginDialogState
        /// </summary>
        private void generateDialogState()
        {
            _StateManager = new LoginDialogState();
        }

        /// <summary>
        /// StateManager of LoginDialog
        /// </summary>
        private LoginDialogState _StateManager;

        /// <summary>
        /// Is Called, when close Event is Triggered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCloseClicked(object sender, EventArgs e)
        {
            _StateManager.setStaus(LoginDialogState.LoginDialogStates.Canceled);
        }


    }
}
