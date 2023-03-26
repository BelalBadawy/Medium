using System.ComponentModel.DataAnnotations;

namespace MediumAPI.Dtos
{
    public class PopularPostsDto
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string BannerImageUrl { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
    }
}
