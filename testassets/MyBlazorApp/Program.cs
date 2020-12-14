using WebWindows.Blazor;
using System;

namespace MyBlazorApp
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ComponentsDesktop.Run<Startup>("My Blazor App", "wwwroot/index.html");
        }
    }
}
