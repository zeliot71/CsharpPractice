﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfaceExample
{
    internal interface ITransport
    {
        public void StartEngine();
        public void StopEngine();
        public void Move();

    }
}
