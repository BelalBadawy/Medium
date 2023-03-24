
using MediumAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MediumAPI.Data.EntityConfiguration
{
    public partial class PostRelatedPostConfiguration : IEntityTypeConfiguration<PostRelatedPost>
    {
        public void Configure(EntityTypeBuilder<PostRelatedPost> builder)
        {
            // table
            builder.ToTable("PostRelatedPosts", "dbo");

                    // key
                   



                    
builder.HasKey(t => new {t.PostId ,t.RelatedPostId });
builder.HasOne(t => t.Posts)
.WithMany(t => t.PostRelatedPosts)
.HasForeignKey(d => d.PostId)
.HasConstraintName("FK_PostRelatedPosts_Posts");
builder.HasOne(t => t.Posts)
.WithMany(t => t.PostRelatedPosts)
.HasForeignKey(d => d.RelatedPostId)
.HasConstraintName("FK_PostRelatedPosts_Posts");
#region Custom
#endregion Custom

}
}
}
