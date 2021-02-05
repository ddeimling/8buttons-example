using EightButtonsExample.Service;
using EightButtonsExample.View;
using EightButtonsExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EightButtonsExample
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var diodeService = new DiodeService();
            var eightButtonsViewModel = new EightButtonsViewModel(diodeService);

            var mainViewModel = new MainViewModel() { Content = eightButtonsViewModel };
            var mainView = new MainView() { DataContext = mainViewModel };
            mainView.Show();
        }
    }
}
