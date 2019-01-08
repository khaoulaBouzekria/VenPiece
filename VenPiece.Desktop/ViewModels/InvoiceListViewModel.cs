using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;
using VenPiece.Desktop.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class InvoiceListViewModel : BindableBase
    {
        public InvoiceListViewModel()
        {
            LoadInvoices();
        }
        private static readonly VenPieceDbContext dbContext = new VenPieceDbContext();
        private IInvoiceRepository _repository = new InvoiceRepository(dbContext);
        private ObservableCollection<Invoice> _invoices;

        public ObservableCollection<Invoice> Invoices
        {
            get { return _invoices; }
            set { SetProperty(ref _invoices, value); }
        }
        

        public async void LoadInvoices()
        {
            Invoices = new ObservableCollection<Invoice>(await _repository.GetClientsAsync());
        }
    }
}
