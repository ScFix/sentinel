namespace Sentinel.Images
{
    using Sentinel.Images.Interfaces;
    using Sentinel.Services;
    using System.Windows;

    public class RemoveTypeImageMapping : IRemoveTypeImage
    {
        public void Remove(ImageTypeRecord typeImageRecord)
        {
            var service = ServiceLocator.Instance.Get<ITypeImageService>();

            if (service != null)
            {
                var prompt = "Are you sure you want to remove the selected image?\r\n\r\n"
                             + $"Image Name = \"{typeImageRecord.Name}\"";

                var result = MessageBox.Show(
                    prompt,
                    "Remove Image",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question,
                    MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    service.ImageMappings.Remove(typeImageRecord);
                }
            }
        }
    }
}