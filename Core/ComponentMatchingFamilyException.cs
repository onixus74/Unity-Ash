﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ash.Core
{
    public class ComponentMatchingFamilyException : Exception
    {
        public ComponentMatchingFamilyException(string message) : base(message)
        {
        }
    }
}