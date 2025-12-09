using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Services
{
    public class ImageService
    {
        private readonly List<string> _imageNames = new();

        public List<Image> GetImages()
        {
            List<Image> images = [];
            foreach (string img in _imageNames)
            {
                Image imgName = new Image { ImageName = img };
                images.Add(imgName);

            }
            return images;
        }

        public void AddImage(string fileName)
        {
            _imageNames.Add(fileName);
        }

        public void ClearImages()
        {
            _imageNames.Clear();
        }
    }
}
