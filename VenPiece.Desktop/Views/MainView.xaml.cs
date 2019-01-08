using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// <summary>
    /// Logique d'interaction pour MainView.xaml
    /// </summary>
    public partial class MainView : MetroWindow, IView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
