using System.Windows.Controls;
using View.ViewModels;

namespace View.Views
{
    /// <summary>
    /// Логика взаимодействия для TriggersView.xaml
    /// </summary>
    public partial class TriggersView : UserControl
    {
        public TriggersView()
        {
            InitializeComponent();
            DataContext = new TriggersViewModel();
        }
    }
}
