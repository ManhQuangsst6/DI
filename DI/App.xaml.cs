using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace DI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Khởi tạo và đăng ký các dependency
            UnityConfig.RegisterComponents();

            // Khởi tạo trang đầu tiên với DI
            var mainWindow = UnityConfig.Container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
