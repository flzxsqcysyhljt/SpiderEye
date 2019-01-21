﻿using System;
using System.Runtime.InteropServices;

namespace SpiderEye.UI.Mac.Native
{
    internal static class AppKit
    {
        private const string AppKitFramework = "/System/Library/Frameworks/AppKit.framework/AppKit";

        [DllImport(AppKitFramework, EntryPoint = "objc_getClass", CharSet = CharSet.Ansi)]
        public static extern IntPtr GetClass(string name);


        public static IntPtr Call(string id, string sel)
        {
            return ObjC.SendMessage(GetClass(id), ObjC.RegisterName(sel));
        }

        public static IntPtr Call(IntPtr id, string sel)
        {
            return ObjC.SendMessage(id, ObjC.RegisterName(sel));
        }
    }
}
