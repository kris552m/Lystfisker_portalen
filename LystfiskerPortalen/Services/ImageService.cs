using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Services
{
    public class ImageService
    {
        private readonly List<string> _pictureNames = new();

        public List<Picture> GetPictures()
        {
            List<Picture> pictures = [];
            foreach (string pic in _pictureNames)
            {
                Picture picName = new Picture { PictureName = pic };
                pictures.Add(picName);

            }
            return pictures;
        }

        public void AddImage(string fileName)
        {
            _pictureNames.Add(fileName);
        }

        public void ClearImages()
        {
            _pictureNames.Clear();
        }
    }
}
