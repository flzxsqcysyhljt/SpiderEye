﻿using System;

namespace SpiderEye.Mac
{
    internal class CocoaApplication : IApplication
    {
        public IWindow MainWindow
        {
            get { throw new NotImplementedException(); }
        }

        private readonly AppConfiguration config;

        public CocoaApplication(AppConfiguration config)
        {
            this.config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
