using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RateMe.Models;

namespace RateMe.Data.EntityConfigurations
{
    public class PictureEntityConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.ToTable("Pictures");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(255);
            builder.Property(p => p.Type);
            builder.Property(p => p.Data);

            builder.HasOne(p=> p.User)
                .WithMany(u => u.Pictures)
                .HasForeignKey(u => u.UserId);

            builder.HasMany(p => p.Comments)
                 .WithOne(c => c.Picture)
                 .HasForeignKey(c => c.PictureId);

        }
    }
}
