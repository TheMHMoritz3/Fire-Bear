﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.XML.Connection
{
    public class BeginElement
    {
        public void parse(string stringToParse)
        {
            string[] elements = stringToParse.Split('>');
        }
    }
}
