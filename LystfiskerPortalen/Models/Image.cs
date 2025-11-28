using System.ComponentModel.DataAnnotations.Schema;

namespace LystfiskerPortalen.Models
{
    public class Image
    {
        //image name er en guid+image name så den er en unik identifier
        public string ImageName { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
