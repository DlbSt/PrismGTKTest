using Prism;
using Prism.Ioc;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace PrismGTKTest.GTK
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App(new GtkInitializer());
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("Your App Name");
            window.Show();

            Gtk.Application.Run();
        }
    }

    public class GtkInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }
}
