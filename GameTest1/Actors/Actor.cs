﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest1.Actors
{
    abstract class Actor
    {
        protected bool IsItem;
        public int x { get; protected set; }
        public int y { get; protected set; }

        
    }
}