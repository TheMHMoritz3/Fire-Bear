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

        /// <summary>
        /// Returns the Value of the Configuration
        /// </summary>
        /// <param name="name">Configuration entry</param>
        /// <returns>Value of the Configuraiton entry</returns>
        public override Object getObjectOf(String name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the Value with the Specific name
        /// </summary>
        /// <param name="name">Configuration entry</param>
        /// <param name="obj">Value of the Configuration entry</param>
        public override void setObjectOf(String name, Object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Contains the Configuraiton
        /// </summary>
        private Dictionary<String,Object> ConfiguraitonMap;
    }
}
