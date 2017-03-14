using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Manager;
using Model.Data;

namespace ClientModel.Manager
{
    public class Connection : IConnection
    {

        Dictionary<LoginData, States.ConnectionState> ConnectionStates;
    }
}
