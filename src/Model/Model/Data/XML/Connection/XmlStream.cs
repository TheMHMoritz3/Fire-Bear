using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Exceptions;
using Model.Data.XML.Types;

namespace Model.Data.XML.Connection
{
    public class XmlStream : XMLElement
    {
        public static XmlStream parse(string stringToParse)
        {
            String[] elements = stringToParse.Split('>');
            XmlStream returnValue = new XmlStream();
            try
            {
                string versionString = elements[0].Remove(0, elements[0].IndexOf('\''));
                versionString = versionString.Remove(versionString.IndexOf('\''));
                returnValue._XmlVersion = Convert.ToDouble(versionString);

            }
            catch(Exception ex)
            {
                throw new WrongElementToParseException();
            }
            return returnValue;
        }

        public double StreamVersion
        {
            get
            {
                return _StreamVersion;
            }
        }

        public double XmlVersion
        {
            get
            {
                return _XmlVersion;
            }
        }

        public string XmlnsStream
        {
            get
            {
                return _XmlnsStream;
            }
        }

        public jabber Xmlns
        {
            get
            {
                return _Xmlns;
            }
        }

        public string To
        {
            get
            {
                return _To;
            }
        }

        public string XmlLang
        {
            get
            {
                return _XmlLang;
            }
        }

        public string XmlnsXml
        {
            get
            {
                return _XmlnsXml;
            }
        }

        private double _StreamVersion;
        private double _XmlVersion;
        private string _XmlnsStream;
        private jabber _Xmlns;
        private string _To;
        private string _XmlLang;
        private string _XmlnsXml;
    }
}
