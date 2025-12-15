using System.ComponentModel.DataAnnotations.Schema;

namespace LystfiskerPortalen.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string PictureName { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
