using System.Windows.Controls;
using Lab3_Mysko.Models;
using Lab3_Mysko.ViewModels;

namespace Lab3_Mysko.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private LoginViewModel _model;

        public LoginView(Storage data)
        {
            InitializeComponent();
            _model = new LoginViewModel(data);
            DataContext = _model;
        }
    }
}