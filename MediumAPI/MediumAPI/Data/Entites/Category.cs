namespace MediumAPI.Data.Entites
{

    public class Category
    {

        public Category()
        {


        }

        public int Id { get; set; }



        public string Title { get; set; }



        public bool IsActive { get; set; }

        public virtual List<PostCategory> PostCategories { get; set; }

    }
}
