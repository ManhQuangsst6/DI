using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DI
{
    public static     class UnityConfig
    {
        private static IUnityContainer _container;

        public static IUnityContainer RegisterComponents()
        {
            _container = new UnityContainer();

            // Đăng ký các dịch vụ, ví dụ:
            _container.RegisterType<ISettingService, SettingService>();
            _container.RegisterType<Page1>();
            _container.RegisterType<Page1ViewModel>();
            return _container;
        }

        public static IUnityContainer Container => _container;
    }
}
