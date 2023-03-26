namespace MediumAPI.Dtos
{
    public class PostsArchivesDto
    {
        public string Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string MonthYearName { get; set; }
        public int PostCounts { get; set; }
    }
}