using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        #region Propiedades
        #endregion

        #region Constructror
        #endregion

        #region Metodos
        #endregion
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.Property(e => e.Abbreviation)
                    .HasMaxLength(5)
                    .IsUnicode(false);

            builder.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
