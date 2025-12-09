using System.ComponentModel.DataAnnotations.Schema;

namespace LystfiskerPortalen.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
