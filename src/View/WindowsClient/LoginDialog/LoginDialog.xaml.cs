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
using Model.Data;
using Model.Data.Security;
using Model.Manager.States;

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
            connectEventsWithWindow();
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
            Close();
        }

        /// <summary>
        /// Connects the Events of the LoginButtonBox with this Window.
        /// </summary>
        private void connectEventsWithWindow()
        {
            _ButtonBox.CancelClicked += onCancelClicked;
            _ButtonBox.LoginClicked += onLoginClicked;
        }

        /// <summary>
        /// Is Called if Cancel is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCancelClicked(object sender, EventArgs e)
        {
            _StateManager.setStaus(LoginDialogState.LoginDialogStates.Canceled);
            Close();
        }

        /// <summary>
        /// Is Called if Login is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onLoginClicked(object sender, EventArgs e)
        {
            _StateManager.setStaus(LoginDialogState.LoginDialogStates.Accepted);
            Close();
        }

        /// <summary>
        /// Generates LoginData
        /// </summary>
        /// <returns>Generated Login Data</returns>
        public LoginData getLogin()
        {
            LoginData returnValue = new LoginData(_UsernameTextBox.Text, _UserPasswordBox.SecurePassword, _DomainTextBox.Text);
            return returnValue;
        }

        /// <summary>
        /// Retruns Status that there is a Possible check, before getting an Exception at getLogin()
        /// </summary>
        /// <returns>Status-Manager</returns>
        public IState getStatusManager()
        {
            return _StateManager;
        }
    }
}
