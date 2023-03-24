
using MediumAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MediumAPI.Data.EntityConfiguration
{
    public partial class PostCommentConfiguration : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            // table
            builder.ToTable("PostComments", "dbo");

                    // key
                   



                    
builder.HasKey(t => t.Id);builder.Property(t => t.Id).HasColumnName("Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd(); 
builder.Property(t => t.PostId).HasColumnName("PostId").HasColumnType("int").IsRequired();
builder.Property(t => t.UserId).HasColumnName("UserId").HasColumnType("int").IsRequired();
builder.Property(t => t.ParentId).HasColumnName("ParentId").HasColumnType("int");
builder.Property(t => t.Comment).HasColumnName("Comment").HasColumnType("nvarchar(max)").HasMaxLength(4000).IsRequired();
builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").HasColumnType("datetime").IsRequired();
builder.Property(t => t.IsActive).HasColumnName("IsActive").HasColumnType("bit").IsRequired();
builder.HasOne(t => t.Posts)
.WithMany(t => t.PostComments)
.HasForeignKey(d => d.PostId)
.HasConstraintName("FK_PostComments_Posts");
#region Custom
#endregion Custom

}
}
}
