using MahApps.Metro.Controls;
using System;
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
