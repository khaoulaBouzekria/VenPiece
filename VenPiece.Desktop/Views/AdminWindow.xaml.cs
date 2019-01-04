using System.Security.Permissions;
using System.Windows;
using VenPiece.Desktop.ViewModels;

namespace VenPiece.Desktop.Views
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    [PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
    public partial class AdminWindow : Window, IView
    {
        public AdminWindow()
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
