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
            DisplayRootViewFor<LoginViewModel>();
        }
    }
}
