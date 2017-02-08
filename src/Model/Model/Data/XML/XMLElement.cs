using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.XML
{
    public class XMLElement
    {

        public XMLElement()
        {
            _Elements = new Dictionary<string, object>();
            _Keys = new List<string>();
            _XMLTag = "";
        }

        public void Add(string key, object element)
        {
            _Elements.Add(key, element);
            _Keys.Add(key);
        }

        public object Get(string key)
        {
            object returnValue;
            _Elements.TryGetValue(key, out returnValue);
            return returnValue;
        }

        public string XMLTag
        {
            set
            {
                _XMLTag = value;
            }

            get
            {
                return _XMLTag;
            }
        }

        private Dictionary<string, object> _Elements;
        private List<string> _Keys;
        private string _XMLTag;
    }
}
