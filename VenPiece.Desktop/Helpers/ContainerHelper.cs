using Unity;
using Unity.Lifetime;
using VenPiece.Data.Repository;

namespace VenPiece.Desktop.Helpers
{
    public static class ContainerHelper
    {
        private static IUnityContainer _container;
        static ContainerHelper()
        {
            _container = new UnityContainer();
            _container.RegisterType<IClientRepository, ClientRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IInvoiceRepository, InvoiceRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IProductRepository, ProductRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IOrderRepository, OrderRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IEmployeeRepository, EmployeeRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IDeliveryRepository, DeliveryRepository>(new ContainerControlledLifetimeManager());
        }
        public static IUnityContainer Container => _container;
    }
}