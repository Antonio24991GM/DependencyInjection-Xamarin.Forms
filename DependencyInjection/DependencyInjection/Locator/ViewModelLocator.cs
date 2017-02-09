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
            _unityContainer.RegisterType<IEmployeeService, EmployeeService>();

            // Register ViewModels here
            _unityContainer.RegisterType<MainViewModel>(new ContainerControlledLifetimeManager());

            var unityServiceLocator = new UnityServiceLocator(_unityContainer);

            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);
        }

        // Create method foreach ViewModel
        public MainViewModel MainViewModel => _unityContainer.Resolve<MainViewModel>();
    }
}
