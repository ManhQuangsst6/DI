using System.Windows;
using System.Windows.Controls;

namespace DI
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        //private readonly ISettingService _settingService;
        public Page1(Page1ViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            //myPopup.IsOpen = true;
            //  _settingService.abc();
        }
    }
}
