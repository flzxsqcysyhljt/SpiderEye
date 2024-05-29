using System;
using SpiderEye;
using SpiderEye.Linux;
using SpiderEye.Windows;

namespace MonoWebViewTest
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.Win32NT:
                case PlatformID.WinCE:
                    WindowsApplication.Init();
                    break;
                case PlatformID.Unix:
                    LinuxApplication.Init();
                    break;
                case PlatformID.MacOSX:
                    break;
                default:
                    break;
            }
            using (var window = new Window())
            {
                Application.ContentProvider = new EmbeddedContentProvider("App");

                Application.Run(window, "https://www.baidu.com");
            }
        }
    }
}
