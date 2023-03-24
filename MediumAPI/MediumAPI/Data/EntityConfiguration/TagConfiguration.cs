
using MediumAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MediumAPI.Data.EntityConfiguration
{
    public partial class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            // table
            builder.ToTable("Tags", "dbo");

                    // key
                   



                    
builder.HasKey(t => t.Id);builder.Property(t => t.Id).HasColumnName("Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd(); 
builder.Property(t => t.Title).HasColumnName("Title").HasColumnType("nvarchar(150)").HasMaxLength(150).IsRequired();
builder.Property(t => t.IsActive).HasColumnName("IsActive").HasColumnType("bit").IsRequired();
#region Custom
#endregion Custom

}
}
}
