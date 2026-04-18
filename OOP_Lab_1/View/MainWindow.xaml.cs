using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _textFromWindow = "Начальное значение из окна";

        /// <summary>
        /// Свойство окна, к которому выполняется прямая привязка
        /// на вкладке DefaultBinding (для сравнения с привязкой к ViewModel).
        /// </summary>
        public string TextFromWindow
        {
            get => _textFromWindow;
            set
            {
                if (_textFromWindow == value)
                    return;

                _textFromWindow = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
