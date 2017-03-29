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
        private XmlStream()
        { }

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
                if (elementParts.Length < 7)
                    throw new WrongElementToParseException();

                if (!elementParts[0].Equals("stream:stream"))
                    throw new WrongElementToParseException();

                if (elementParts[1].Remove(0, elementParts[1].IndexOf('\'')).Remove(elementParts[1].IndexOf('\'')).Equals("jabber:client"))
                    returnValue._Xmlns = jabber.client;
                else
                    returnValue._Xmlns = jabber.server;

                returnValue._XmlnsStream = elementParts[2].Remove(0, elementParts[2].IndexOf('\'')).Remove(elementParts[2].IndexOf('\''));
                returnValue._Id = Convert.ToInt32(elementParts[3].Remove(0, elementParts[3].IndexOf('\'')).Remove(elementParts[3].IndexOf('\'')));
                returnValue._From = elementParts[4].Remove(0, elementParts[4].IndexOf('\'')).Remove(elementParts[4].IndexOf('\''));
                returnValue._StreamVersion = Convert.ToDouble(elementParts[5].Remove(0, elementParts[5].IndexOf('\'')).Remove(elementParts[5].IndexOf('\'')));
                returnValue._XmlLang = elementParts[6].Remove(0, elementParts[6].IndexOf('\'')).Remove(elementParts[6].IndexOf('\''));
            }
            catch(Exception ex)
            {
                throw new WrongElementToParseException();
            }
            return returnValue;
        }

        public static XmlStream createNewStreamElement()
        {
            XmlStream returnValue = new XmlStream();

            returnValue._XmlVersion=1.0;


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

        public string From
        {
            get
            {
                return _From;
            }
        }

        public string toXML()
        {
            return "";
        }

        private double _StreamVersion;
        private double _XmlVersion;
        private string _XmlnsStream;
        private int _Id;
        private jabber _Xmlns;
        private string _To;
        private string _XmlLang;
        private string _XmlnsXml;
        private string _From;
        private readonly ElementType _ElementType = ElementType.StreamElement;
    }
}
