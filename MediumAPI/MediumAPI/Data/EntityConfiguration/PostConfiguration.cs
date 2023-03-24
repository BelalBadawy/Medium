
using MediumAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MediumAPI.Data.EntityConfiguration
{
    public partial class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            // table
            builder.ToTable("Posts", "dbo");

                    // key
                   



                    
builder.HasKey(t => t.Id);builder.Property(t => t.Id).HasColumnName("Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd(); 
builder.Property(t => t.UserId).HasColumnName("UserId").HasColumnType("int").IsRequired();
builder.Property(t => t.Slug).HasColumnName("Slug").HasColumnType("nvarchar(300)").HasMaxLength(300).IsRequired();
builder.Property(t => t.Title).HasColumnName("Title").HasColumnType("nvarchar(300)").HasMaxLength(300).IsRequired();
builder.Property(t => t.Description).HasColumnName("Description").HasColumnType("nvarchar(1000)").HasMaxLength(1000);
builder.Property(t => t.PostContent).HasColumnName("PostContent").HasColumnType("nvarchar(max)").HasMaxLength(4000).IsRequired();
builder.Property(t => t.BannerImageUrl).HasColumnName("BannerImageUrl").HasColumnType("nvarchar(1000)").HasMaxLength(1000);
builder.Property(t => t.IsActive).HasColumnName("IsActive").HasColumnType("bit").IsRequired();
builder.Property(t => t.CommentsEnabled).HasColumnName("CommentsEnabled").HasColumnType("bit").IsRequired();
builder.Property(t => t.ViewCount).HasColumnName("ViewCount").HasColumnType("int").IsRequired();
builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").HasColumnType("datetime").IsRequired();
#region Custom
#endregion Custom

}
}
}
