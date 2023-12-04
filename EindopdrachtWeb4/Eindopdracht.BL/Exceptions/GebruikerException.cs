﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.BL.Exceptions
{
    public class GebruikerException : Exception
    {
        public GebruikerException(string? message) : base(message)
        {
        }

        public GebruikerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}