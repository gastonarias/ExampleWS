﻿using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleWS
{
    public class HelloResponse
    {
        public ResponseStatus ResponseStatus { get; set; } //Automatic exception handling

        public string Result { get; set; }
    }
}