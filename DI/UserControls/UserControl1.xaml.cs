using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DI.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "D:\\KenshinDX\\documentchecktool\\DocCheckOrderService\\bin\\Debug\\DocCheckOrderService.exe",
                WorkingDirectory = "D:\\KenshinDX\\documentchecktool\\DocCheckOrderService\\bin\\Debug",
                UseShellExecute = true
            };
            var process = Process.Start(startInfo);

            //if (process != null && !process.HasExited)
            //{
            //    process.Kill(); // Dừng ngay lập tức
            //}

            MyCommand?.Execute("Parameter from UserControl");
        }
        public static readonly DependencyProperty MyCommandProperty =
        DependencyProperty.Register("MyCommand", typeof(ICommand), typeof(UserControl1), new PropertyMetadata(null));

        public ICommand MyCommand
        {
            get => (ICommand)GetValue(MyCommandProperty);
            set => SetValue(MyCommandProperty, value);
        }
    }
}
