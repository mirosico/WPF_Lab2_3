using System.Windows.Input;
using Lab3_Mysko.Managers;
using Lab3_Mysko.Models;
using Lab3_Mysko.Tools;

namespace Lab3_Mysko.ViewModels
{
    class UserInfoViewModel : ObservableItem
    {
        private string _name, _surname, _email, _birthDay, _isAdult, _sunSign, _chineseSign, _isBirthDay;
        private ICommand _goBackCommand;

        public UserInfoViewModel(Storage data)
        {
            data.UserChanged += UserInfo;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Birthday
        {
            get => _birthDay;
            set
            {
                _birthDay = value;
                OnPropertyChanged();
            }
        }

        public string IsAdult
        {
            get => _isAdult;
            set
            {
                _isAdult = value;
                OnPropertyChanged();
            }
        }

        public string SunSign
        {
            get => _sunSign;
            set
            {
                _sunSign = value;
                OnPropertyChanged();
            }
        }

        public string ChineseSign
        {
            get => _chineseSign;
            set
            {
                _chineseSign = value;
                OnPropertyChanged();
            }
        }

        public string IsBirthday
        {
            get => _isBirthDay;
            set
            {
                _isBirthDay = value;
                OnPropertyChanged();
            }
        }

        public ICommand GoBackCommand
        {
            get
            {
                if (_goBackCommand == null)
                    _goBackCommand = new RelayCommand(ExecuteGoBack, null);
                return _goBackCommand;
            }
        }

        private void ExecuteGoBack(object obj)
        {
            NavigationManager.Instance.Navigate(Models.Views.LoginView);
        }

        private void UserInfo(Person user)
        {
            var birth = user.BirthDate;
            Name = user.Name;
            Surname = user.Surname;
            Email = user.Email;
            Birthday = $"{birth.Day}.{birth.Month}.{birth.Year}";
            IsAdult = user.IsAdult ? "Yes" : "No";
            SunSign = user.SunSign;
            ChineseSign = user.ChineseSign;
            IsBirthday = user.IsBirthDay ? "Yes" : "No";
        }
    }
}