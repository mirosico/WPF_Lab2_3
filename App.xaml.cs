using System.Windows;
using Lab3_Mysko.Managers;
using Lab3_Mysko.Models;

namespace Lab3_Mysko
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow mainWindow = new MainWindow();
            Storage data = new Storage();
            NavigationManager.Instance.Initialise(new NavigationModel(mainWindow, data));
            NavigationManager.Instance.Navigate(Models.Views.LoginView);
            mainWindow.Show();
        }
    }
}