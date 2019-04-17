using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab3_Mysko.Tools
{
    class ObservableItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
