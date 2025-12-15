using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Services
{
    public class ImageService
    {
        private readonly List<string> _imageNames = new();

        public List<Picture> GetImages()
        {
            List<Picture> images = [];
            foreach (string img in _imageNames)
            {
                Picture imgName = new Picture { ImageName = img };
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
