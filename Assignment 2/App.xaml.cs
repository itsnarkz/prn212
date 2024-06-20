using Assignment1PRN.Util;
using Assignment1PRN.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Navigation;

namespace Assignment1PRN
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly Navigation navigation;
        public App()
        {
            navigation = new Navigation();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            
            navigation.ViewModel = new LoginPageViewModel(navigation);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigation)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
