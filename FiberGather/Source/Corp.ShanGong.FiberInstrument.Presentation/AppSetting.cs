﻿using Autofac;
using Corp.ShanGong.FiberInstrument.Setting;

namespace Corp.ShanGong.FiberInstrument.Presentation
{
    public static class AppSetting
    {
        public static IContainer Container
        {
            get;
            set;
        }

        public static GlobalSetting StartupConfig
        {
            get;
            set;
        }
    }
}