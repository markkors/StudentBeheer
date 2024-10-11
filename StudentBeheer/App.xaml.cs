using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StudentBeheer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Dit is de entry point van de applicatie
        // Hier wordt de database geïnitialiseerd
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Models.DatabaseHelper.InitializeDatabase();
        }
    }
}
