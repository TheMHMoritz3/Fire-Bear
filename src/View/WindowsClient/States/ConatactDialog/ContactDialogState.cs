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
    class ContactDialogState : IState
    {
        public enum ConstactDialofStates
        {
            Closed = 0,
            Canceled = 1,
            Accepted = 2
        }

        public int getState()
        {
            return 0;
        }
    }
}
