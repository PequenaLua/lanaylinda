﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class EmailExistenteException : Exception
    {
        public EmailExistenteException(string message) : base(message)
        {
        }
    }
}
