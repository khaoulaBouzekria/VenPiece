using System;
using System.Windows;
using Caliburn.Micro;
using VenPiece.Desktop.Security;
using VenPiece.Desktop.Services;
using VenPiece.Desktop.ViewModels;
using VenPiece.Desktop.Views;

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
            CustomPrincipal customPrincipal = new CustomPrincipal();
            AppDomain.CurrentDomain.SetThreadPrincipal(customPrincipal);
            //DisplayRootViewFor<LoginViewModel>();
            //Show the login view
            AuthenticationViewModel viewModel = new AuthenticationViewModel(new AuthenticationService());
            IView loginWindow = new LoginWindow(viewModel);
            loginWindow.Show();
        }
    }
}
