using System.Collections.ObjectModel;
using VenPiece.Data;
using VenPiece.Data.Models;
using VenPiece.Data.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class InvoiceListViewModel : BindableBase
    {
        public InvoiceListViewModel(IInvoiceRepository invoiceRepository)
        {
            _repository = invoiceRepository;
            LoadInvoices();
        }
        private IInvoiceRepository _repository;
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
