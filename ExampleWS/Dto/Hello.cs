﻿using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleWS
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello
    {
        public string Name { get; set; }
    }
}