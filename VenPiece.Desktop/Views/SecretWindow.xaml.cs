using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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
