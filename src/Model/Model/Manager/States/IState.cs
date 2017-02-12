using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Manager.States
{
    /// <summary>
    /// Uniform Interface of all States
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Retruns integer of the Enum of the State
        /// </summary>
        /// <returns>Enum of the State</returns>
        int getState();
    }
}
