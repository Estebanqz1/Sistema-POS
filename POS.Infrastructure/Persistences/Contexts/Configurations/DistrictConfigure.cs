using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class DistrictConfigure : IEntityTypeConfiguration<District>
    {
        #region Propiedades
        #endregion

        #region Constructror
        #endregion

        #region Metodos
        #endregion
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.Property(e => e.Name)
                   .HasMaxLength(100)
                   .IsUnicode(false);

            builder.HasOne(d => d.Province)
                .WithMany(p => p.Districts)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Districts_Provinces");
        }
    }
}
