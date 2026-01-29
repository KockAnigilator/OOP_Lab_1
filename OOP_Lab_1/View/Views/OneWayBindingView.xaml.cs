using System.Windows.Controls;
using View.ViewModels;

namespace View.Views
{
    /// <summary>
    /// Логика взаимодействия для OneWayBindingView.xaml
    /// </summary>
    public partial class OneWayBindingView : UserControl
    {
        public OneWayBindingView()
        {
            InitializeComponent();
            DataContext = new OneWayBindingViewModel();
        }
    }
}
