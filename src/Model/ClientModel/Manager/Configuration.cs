using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Manager;

namespace ClientModel.Manager
{
    /// <summary>
    /// Represents the Client Configuration
    /// </summary>
    public class Configuration : IConfiguration
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Configuration()
        {
            ConfiguraitonMap = new Dictionary<String, Object>();
        }

        public override Object getObjectOf(String name)
        {
            throw new NotImplementedException();
        }

        public override void setObjectOf(String name, Object obj)
        {
            throw new NotImplementedException();
        }

        private Dictionary<String,Object> ConfiguraitonMap;
    }
}
