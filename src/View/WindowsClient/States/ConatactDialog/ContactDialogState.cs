using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Manager.States;
using Model;

namespace WindowsClient.States.ConatactDialog
{
    /// <summary>
    /// ContactDialogState represents all states of the ConatactDialog
    /// </summary>
    public class ContactDialogState : IState
    {
        /// <summary>
        /// Represents all Possible States
        /// </summary>
        public enum ContactDialogStates
        {
            Closed = 0,
            Canceled = 1,
            Accepted = 2
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        public ContactDialogState()
        {
            _CurrentState = ContactDialogStates.Closed;
        }

        /// <summary>
        /// Retruns and Sets the Current State
        /// </summary>
        public ContactDialogStates CurrentState
        {
            get
            {
                return _CurrentState;
            }
            set
            {
                _CurrentState = value;
            }
        }

        /// <summary>
        /// Integer of the current State
        /// </summary>
        /// <returns></returns>
        public int getState()
        {
            return 0;
        }

        /// <summary>
        /// Current State
        /// </summary>
        private ContactDialogStates _CurrentState;
    }
}
