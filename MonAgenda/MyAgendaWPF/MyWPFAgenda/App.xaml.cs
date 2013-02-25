using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace MyWPFAgenda
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Preferences Preferences;

        protected override void OnExit(ExitEventArgs e)
        {
            if (Preferences != null)
                Preferences.save();

            base.OnExit(e);
        }

        private void Application_DispatcherUnhandledException_1(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {
                MessageBox.Show(e.Exception.ToString());
                e.Handled = true;
            }
            catch
            {
            }
        }
    }
}
