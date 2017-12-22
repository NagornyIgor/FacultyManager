﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace FacultyManager.Applicatiion
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HttpClient httpClient;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(10),
                BaseAddress = new Uri("http://localhost:52002/api/")
            };

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }

}
