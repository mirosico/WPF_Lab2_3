using System.Windows.Controls;
using Lab3_Mysko.Models;
using Lab3_Mysko.ViewModels;

namespace Lab3_Mysko.Views
{
    /// <summary>
    /// Interaction logic for UserInfoView.xaml
    /// </summary>
    public partial class UserInfoView : UserControl
    {
        private UserInfoViewModel _model;

        public UserInfoView(Storage data)
        {
            InitializeComponent();
            _model = new UserInfoViewModel(data);
            DataContext = _model;
        }
    }
}