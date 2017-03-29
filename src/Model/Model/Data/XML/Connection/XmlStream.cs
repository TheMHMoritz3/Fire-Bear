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
                string versionString = elements[0].Remove(0, elements[0].IndexOf('"'));
                versionString = versionString.Remove(versionString.IndexOf('"'));
                returnValue._XmlVersion = Convert.ToDouble(versionString);

                string[] elementParts = elements[1].Split(' ');
                if (elementParts.Length < 1)
                    throw new WrongElementToParseException();

                if (!elementParts[0].Equals("stream:stream"))
                    throw new WrongElementToParseException();

                returnValue._XmlnsStream = elementParts[1].Remove(0, elementParts[1].IndexOf('"')).Remove(elementParts[1].IndexOf('"'));
                returnValue._Id = Convert.ToInt32(elementParts[2].Remove(0, elementParts[2].IndexOf('"')).Remove(elementParts[2].IndexOf('"')));
                returnValue._XmlnsStream = elementParts[1].Remove(0, elementParts[1].IndexOf('"')).Remove(elementParts[1].IndexOf('"'));
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

        public ElementType getElementType()
        {
            return _ElementType;
        }

        public int Id
        {
            get
            {
                return _Id;
            }
        }

        private double _StreamVersion;
        private double _XmlVersion;
        private string _XmlnsStream;
        private int _Id;
        private jabber _Xmlns;
        private string _To;
        private string _XmlLang;
        private string _XmlnsXml;
        private readonly ElementType _ElementType = ElementType.StreamElement;
    }
}
