using System;
using System.Windows;
using System.Windows.Input;
using Lab3_Mysko.Managers;
using Lab3_Mysko.Models;
using Lab3_Mysko.Tools;

namespace Lab3_Mysko.ViewModels
{
    class LoginViewModel : ObservableItem
    {
        private string _name, _surname, _email;
        private DateTime _date;

        private ICommand _processCommand;

        public LoginViewModel(Storage data)
        {
            _name = "";
            _surname = "";
            _email = "";
            _date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Model = new UserInputModel(data);
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
        public DateTime SelectedDate
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public UserInputModel Model { get; private set; }

        public ICommand ProcessCommand
        {
            get
            {
                if (_processCommand == null)
                    _processCommand = new RelayCommand(ExecuteProcess);
                return _processCommand;
            }
        }

        private void ExecuteProcess(object obj)
        {
            try
            {
                Model.SetUser(_name, _surname, _email, _date);
                if (Model.IsBirthDay())
                    MessageBox.Show("Happy Birthday!Let your all the dreams to be on fire and light your birthday candles with that. \nHave a gorgeous birthday", "Birthday");
                NavigationManager.Instance.Navigate(Models.Views.UserInfoView);
            }
            catch (PersonException ex)
            {
                MessageBox.Show(ex.Message,"Error !");
            }
        }
    }
}