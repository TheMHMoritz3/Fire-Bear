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
        public enum LoginDialogStates
        {
            Accepted,
            Canceled
        };

        public int getState()
        {
            return 0;
        }
    }
}
