using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Manager.States;

namespace ClientModel.Manager.States
{
    public class ConfigurationSaveState : IState
    {
        public enum SaveStates
        {
            Changed,
            Saved,
            Canceld
        }

        public int getState()
        {
            throw new NotImplementedException();
        }
    }
}
