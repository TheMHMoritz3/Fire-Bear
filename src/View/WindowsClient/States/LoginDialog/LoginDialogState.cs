using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Manager.States;

namespace WindowsClient.States.LoginDialog
{
    /// <summary>
    /// Is needed because of custom Login Dialog
    /// </summary>
    public class LoginDialogState : IState
    {
        /// <summary>
        /// Possible Loginstates for a Dialog
        /// </summary>
        public enum LoginDialogStates:int
        {
            NoState = 0,
            Accepted = 1,
            Canceled = 2
        };

        /// <summary>
        /// Constructor
        /// </summary>
        public LoginDialogState()
        {
            _CurrentStatus = LoginDialogStates.NoState;
        }

        /// <summary>
        /// That the Dialog is Able to Set the Current Status
        /// </summary>
        /// <param name="state">Current Status</param>
        public void setStaus(LoginDialogStates state)
        {
            _CurrentStatus = state;
        }

        /// <summary>
        /// Returns the current dialog state
        /// </summary>
        /// <returns>Current dialog state as LoginDialogStates</returns>
        public LoginDialogStates currentDialogState()
        {
            return _CurrentStatus;
        }


        public int getState()
        {
            return (int)_CurrentStatus;
        }

        private LoginDialogStates _CurrentStatus;
    }
}
