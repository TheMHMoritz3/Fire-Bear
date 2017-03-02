using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Manager
{
    /// <summary>
    /// Gives a Basic Interface for the Configuration of Server and Client
    /// </summary>
    public abstract class IConfiguration
    {
        /// <summary>
        /// Returns a Obajct wich is Represented in The JsonFile
        /// </summary>
        /// <param name="name">Name of the Object of the JSON File</param>
        /// <returns>Object Value</returns>
        public abstract Object getObjectOf(String name);
        /// <summary>
        /// Adds or Rests the Object of the Object with the Name
        /// </summary>
        /// <param name="name">Name of the Object in the JSONFile</param>
        /// <param name="obj">Configuraiton Value</param>
        public abstract void setObjectOf(String name, Object obj);
        /// <summary>
        /// Path of the Configuration File
        /// </summary>
        protected String FilePath;
    }
}
