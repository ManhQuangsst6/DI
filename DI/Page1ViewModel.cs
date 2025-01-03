using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DI
{
    public class Page1ViewModel : INotifyPropertyChanged
    {
        private readonly ISettingService _settingService;

        public Page1ViewModel(ISettingService settingService)
        {
            _settingService = settingService;
            Title = "Hi";
            MyCommand = new RelayCommand(OnMyCommandExecuted);
            HandleUserControlEventCommand = new RelayCommand<object>(ExecuteHandleUserControlEvent);

        }
        private string _title;
        public string Title
        {
            set { _title = value; OnPropertyChanged("Title"); }
            get { return _title; }
        }
        public ObservableCollection<string> data1 = new ObservableCollection<string>() { "1", "2" };
        public ICommand MyCommand { get; }
        private void OnMyCommandExecuted()
        {
            _settingService.abc();

        }
        public ICommand HandleUserControlEventCommand { get; }
        private void ExecuteHandleUserControlEvent(object parameter)
        {
            // Xử lý sự kiện từ UserControl
            Console.WriteLine($"Received: {parameter}");
        }

        // Implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
