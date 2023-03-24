
using MediumAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MediumAPI.Data.EntityConfiguration
{
    public partial class PostCategoryConfiguration : IEntityTypeConfiguration<PostCategory>
    {
        public void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            // table
            builder.ToTable("PostCategories", "dbo");

                    // key
                   



                    
builder.HasKey(t => new {t.CategoryId ,t.PostId });
builder.HasOne(t => t.Categories)
.WithMany(t => t.PostCategories)
.HasForeignKey(d => d.CategoryId)
.HasConstraintName("FK_PostCategories_Categories");
builder.HasOne(t => t.Posts)
.WithMany(t => t.PostCategories)
.HasForeignKey(d => d.PostId)
.HasConstraintName("FK_PostCategories_Posts");
#region Custom
#endregion Custom

}
}
}
