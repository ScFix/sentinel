namespace Sentinel.Filters.Gui
{
    using Sentinel.Filters.Interfaces;
    using Sentinel.Services;
    using System.Windows;

    public class RemoveFilter : IRemoveFilterService
    {
        public void Remove(IFilter filter)
        {
            var service = ServiceLocator.Instance.Get<IFilteringService<IFilter>>();

            if (service != null)
            {
                var prompt = "Are you sure you want to remove the selected filter?\r\n\r\n" +
                                $"Filter Name = \"{filter.Name}\"";

                var result = MessageBox.Show(
                    prompt,
                    "Remove Filter",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question,
                    MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    service.Filters.Remove(filter);
                }
            }
        }
    }
}