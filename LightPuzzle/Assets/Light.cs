﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Light
    {
        public List<Line> Lines { get; set; }        
        public Light()
        {
            Lines = new List<Line>();
        }
    }
}
