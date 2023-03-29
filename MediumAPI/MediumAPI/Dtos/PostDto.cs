using System.ComponentModel.DataAnnotations;

namespace MediumAPI.Dtos
{
    public class PostDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Slug { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }

        public string BannerImageUrl { get; set; }

        public int ViewCount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        public int PostCommentsCount { get; set; }

        public List<string> PostTags { get; set; }

        public List<string> PostCategories { get; set; }


    }
}