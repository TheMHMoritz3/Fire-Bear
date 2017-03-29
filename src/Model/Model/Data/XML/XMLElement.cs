using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data.XML.Types;

namespace Model.Data.XML
{
    interface XMLElement
    {
        ElementType getElementType();
        string toXML();
    }
}
