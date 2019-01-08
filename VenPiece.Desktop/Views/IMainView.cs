using VenPiece.Desktop.ViewModels;

namespace VenPiece.Desktop.Views
{
    public interface IMainView
    {
        IViewModel ViewModel { get; set; }

        void InitializeComponent();
        void Show();
    }
}