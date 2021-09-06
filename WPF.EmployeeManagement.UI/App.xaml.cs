﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.EmployeeManagement.UI.Data;
using WPF.EmployeeManagement.UI.ViewModel;

namespace WPF.EmployeeManagement.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartUp(object sender, StartupEventArgs e)
        {
            new MainWindow(
                new MainViewModel(
                    new EmployeeDataService()))
                .Show();
        }
    }
}
