namespace View.ViewModels
{
    /// <summary>
    /// ViewModel для вкладки Triggers.
    /// Используется для демонстрации DataTrigger и MultiTrigger.
    /// </summary>
    public class TriggersViewModel : BaseViewModel
    {
        private string _status;
        private bool _isImportant;

        /// <summary>
        /// Статус для DataTrigger (например: Normal, Warning, Error).
        /// </summary>
        public string Status
        {
            get => _status;
            set => SetProperty(ref _status, value);
        }

        /// <summary>
        /// Флаг важности, используемый в MultiTrigger.
        /// </summary>
        public bool IsImportant
        {
            get => _isImportant;
            set => SetProperty(ref _isImportant, value);
        }

        public TriggersViewModel()
        {
            Status = "Normal";
            IsImportant = false;
        }
    }
}
