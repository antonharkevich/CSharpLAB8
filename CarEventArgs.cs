﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class CarEventArgs: EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message)
        {
            msg = message;
        }
    }
}
