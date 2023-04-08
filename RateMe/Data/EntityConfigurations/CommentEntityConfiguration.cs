using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RateMe.Models;

namespace RateMe.Data.EntityConfigurations
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Value).HasMaxLength(255);

            builder.HasOne(c => c.Picture)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PictureId);
        }
    }
}
