using System;
using Lab3_Mysko.Views;

namespace Lab3_Mysko.Models
{
    enum Views
    {
        LoginView,
        UserInfoView
    }

    class NavigationModel
    {
        private Storage _data;
        private MainWindow _window;
        private LoginView _LoginView;
        private UserInfoView _userInfoView;

        public NavigationModel(MainWindow window, Storage data)
        {
            _window = window;
            _data = data;
            _LoginView = new LoginView(data);
            _userInfoView = new UserInfoView(_data);
        }

        public void Navigate(Views view)
        {
            switch (view)
            {
                case Views.LoginView:
                    _window.Title = "Input";
                    _window.MinWidth = 400;
                    _window.MinHeight = 370;
                    _window.WindowContents.Content = _LoginView;
                    break;
                case Views.UserInfoView:
                    _window.Title = "Info";
                    _window.MinHeight = 400;
                    _window.WindowContents.Content = _userInfoView;
                    break;
                default:
                    throw new ArgumentException("Inappropriate parameter for navigation !");
            }
        }
    }
}