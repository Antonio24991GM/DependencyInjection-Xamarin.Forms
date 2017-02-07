using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public interface IDeviceOrientation
    {
        DeviceOrientations GetOrientation();
    }
}