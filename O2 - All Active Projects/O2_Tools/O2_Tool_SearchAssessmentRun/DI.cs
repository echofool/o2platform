﻿using O2.Kernel.Interfaces.O2Core;
using O2.Kernel.InterfacesBaseImpl;

namespace O2.Tool.SearchAssessmentRun
{
    internal class DI
    {
        public static IO2Log log = new KO2Log();
        public static IO2Config config = new KO2Config();
    }
}