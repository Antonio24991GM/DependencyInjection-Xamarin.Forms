using DependencyInjection.Services;
using DependencyInjection.ViewModels;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace DependencyInjection.Locator
{
    public class ViewModelLocator
    {
        private UnityContainer _unityContainer;

        public ViewModelLocator()
        {
            _unityContainer = new UnityContainer();

            // Register Services here
            RegisterServices(_unityContainer);
            //_unityContainer.RegisterType<IDeviceOrientation>();

            // Register ViewModels here
            _unityContainer.RegisterType<MainViewModel>(new ContainerControlledLifetimeManager());

            var unityServiceLocator = new UnityServiceLocator(_unityContainer);

            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);
        }

        protected virtual void RegisterServices(UnityContainer unityContainer)
        {
        }

        // Create method foreach ViewModel
        public MainViewModel MainViewModel => _unityContainer.Resolve<MainViewModel>();
    }
}
