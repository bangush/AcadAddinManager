﻿using System;
using System.Collections.Generic;
using NetLib.IO;

namespace AcadAddinManager.Data
{
    public class Addin
    {
        public List<CommandMethod> Commands { get; set; }
        public string AddinFile { get; set; }
        public string AddinTempFile { get; set; }
        public List<DllResolve> Resolvers { get; set; }
    }
}