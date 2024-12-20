﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiagoPanchi.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://www.linkedin.com/in/santiago-panchi-3627ab33b/";
        public string Message => "This app is written in XAML and C# with .NET MAUI.";
    }
}
