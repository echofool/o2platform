﻿using System;
using O2.DotNetWrappers.Network;
using O2.DotNetWrappers.Windows;
using O2.Kernel;
using System.Drawing;

namespace O2.DotNetWrappers.ExtensionMethods
{
    public static class Misc_ExtensionMethods
    {
        public static void sleep(this object _object, int miliseconds)
        {
            Processes.Sleep(miliseconds);
        }

        public static void sleep(this object _object, int miliseconds, bool verbose)
        {
            Processes.Sleep(miliseconds, verbose);
        }

        public static string o2Temp2Dir(this object _object)
        {
            return PublicDI.config.O2TempDir;
        }

        public static string tempO2Dir(this object _object)
        {
            return PublicDI.config.O2TempDir;
        }

        public static string tempDir(this object _object)
        {
            return _object.tempO2Dir();
        }

        public static bool isFalse(this bool value)
        {
            return value == false;
        }

        public static bool isTrue(this bool value)
        {
            return value == true;
        }

        public static Bitmap bitmap(this string file)
        {
            if (file.fileExists())
                return new Bitmap(file);
            return null;
        }
    }
}