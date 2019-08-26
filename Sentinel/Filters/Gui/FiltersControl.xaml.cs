namespace Sentinel.Filters.Gui
{
    using Sentinel.Filters.Interfaces;
    using Sentinel.Services;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for FiltersControl.xaml
    /// </summary>
    public partial class FiltersControl : UserControl
    {
        public FiltersControl()
        {
            InitializeComponent();

            var service = ServiceLocator.Instance.Get<IFilteringService<IFilter>>();
            if (service != null)
            {
                Filters = service;
            }

            DataContext = this;
        }

        public IFilteringService<IFilter> Filters { get; private set; }
    }
}