using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.webapi.DataModels
{
    [Table("posts")]
    public class Post
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("body")]
        public string Body { get; set; }
        [Column("fk_authorid")]
        [ForeignKey("ApplicationUser")]
        public Guid AuthorId { get; set; }
    }
}
