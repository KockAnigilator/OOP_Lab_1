using System;
using System.Windows.Threading;

namespace View.ViewModels
{
    /// <summary>
    /// ViewModel для вкладки OneWayBinding.
    /// Демонстрирует односторонний поток данных (источник → UI):
    /// прогресс, прошедшее время, вычисляемые свойства.
    /// </summary>
    public class OneWayBindingViewModel : BaseViewModel
    {
        private readonly DateTime _startTime;
        private readonly DispatcherTimer _timer;

        private int _progress;
        private TimeSpan _elapsed;

        /// <summary>
        /// Прогресс от 0 до 100 (источник для ProgressBar, TextBlock).
        /// Односторонняя привязка: UI не меняет это значение.
        /// </summary>
        public int Progress
        {
            get => _progress;
            private set => SetProperty(ref _progress, value);
        }

        /// <summary>
        /// Время, прошедшее с момента запуска ViewModel.
        /// </summary>
        public TimeSpan Elapsed
        {
            get => _elapsed;
            private set
            {
                if (SetProperty(ref _elapsed, value))
                {
                    // Обновляем вычисляемое свойство
                    OnPropertyChanged(nameof(ElapsedFormatted));
                }
            }
        }

        /// <summary>
        /// Вычисляемое свойство для отображения прошедшего времени в удобном формате.
        /// </summary>
        public string ElapsedFormatted => $"{(int)Elapsed.TotalSeconds} сек.";

        public OneWayBindingViewModel()
        {
            _startTime = DateTime.Now;
            Progress = 0;
            Elapsed = TimeSpan.Zero;

            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _timer.Tick += (s, e) =>
            {
                Elapsed = DateTime.Now - _startTime;
                if (Progress < 100)
                {
                    Progress += 5;
                }
            };
            _timer.Start();
        }
    }
}
