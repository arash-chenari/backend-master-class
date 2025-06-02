using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApi.Models.Books
{
    public class BookEntityMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Boks");

            builder.HasKey(x => x.Id);
            builder.Property(b => b.Id).UseIdentityColumn();

            builder.Property(b => b.Title)
                .HasMaxLength(50);

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);
        }
    }
}
