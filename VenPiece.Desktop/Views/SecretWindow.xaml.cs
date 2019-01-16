using System.Security.Permissions;
using System.Windows;
using VenPiece.Desktop.ViewModels;

namespace VenPiece.Desktop.Views
{
    /// <inheritdoc />
    /// <summary>
    /// Interaction logic for SecretWindow.xaml
    /// </summary>
    [PrincipalPermission(SecurityAction.Demand)]
    public partial class SecretWindow : Window, IView
    {
        public SecretWindow()
        {
            InitializeComponent();
        }

        #region IView Members

        public IViewModel ViewModel
        {
            get => DataContext as IViewModel;
            set => DataContext = value;
        }

        #endregion
    }
}
