using System.Windows;
using Caliburn.Micro;
using VenPiece.Desktop.ViewModels;

namespace VenPiece.Desktop
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //CustomPrincipal customPrincipal = new CustomPrincipal();
            //AppDomain.CurrentDomain.SetThreadPrincipal(customPrincipal);
            DisplayRootViewFor<MainViewModel>();
            //Show the login view
            //AuthenticationViewModel viewModel = new AuthenticationViewModel(new AuthenticationService());
            //IView loginWindow = new LoginWindow(viewModel);
            //loginWindow.Show();
            //LoginViewModel viewModel = new LoginViewModel(new AuthenticationService());
            //IView loginView = new LoginView(viewModel);
            //loginView.Show();
        }
    }
}
