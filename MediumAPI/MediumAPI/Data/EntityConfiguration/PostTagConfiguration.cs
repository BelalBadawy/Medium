
using MediumAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MediumAPI.Data.EntityConfiguration
{
    public partial class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            // table
            builder.ToTable("PostTags", "dbo");

                    // key
                   



                    
builder.HasKey(t => new {t.TageId ,t.PostId });
builder.HasOne(t => t.Posts)
.WithMany(t => t.PostTags)
.HasForeignKey(d => d.PostId)
.HasConstraintName("FK_PostTags_Posts");
builder.HasOne(t => t.Tags)
.WithMany(t => t.PostTags)
.HasForeignKey(d => d.TageId)
.HasConstraintName("FK_PostTags_Tags");
#region Custom
#endregion Custom

}
}
}
