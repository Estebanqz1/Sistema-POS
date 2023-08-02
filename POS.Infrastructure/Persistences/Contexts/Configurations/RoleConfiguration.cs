using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        #region Propiedades
        #endregion

        #region Constructror
        #endregion

        #region Metodos
        #endregion
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(e => e.Description)
                   .HasMaxLength(50)
                   .IsUnicode(false);
        }
    }
}
