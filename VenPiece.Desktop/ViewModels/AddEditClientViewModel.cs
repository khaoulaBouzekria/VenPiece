using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.ViewModels
{
    public class AddEditClientViewModel : BindableBase
    {
        private bool _EditMode;
        public bool EditMode
        {
            get { return _EditMode;} set { SetProperty(ref _EditMode,value); } }

        private Client _editingClient = null;
        public void SetClient(Client client)
        {
            _editingClient = client;
        }
    }
}
