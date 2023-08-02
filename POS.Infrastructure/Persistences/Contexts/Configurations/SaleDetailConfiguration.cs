﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class SaleDetailConfiguration : IEntityTypeConfiguration<SaleDetail>
    {
        #region Propiedades
        #endregion

        #region Constructror
        #endregion

        #region Metodos
        #endregion
        public void Configure(EntityTypeBuilder<SaleDetail> builder)
        {
            builder.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

            builder.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__SaleDetai__Produ__6A30C649");

            builder.HasOne(d => d.Sale)
                .WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.SaleId)
                .HasConstraintName("FK__SaleDetai__SaleI__6B24EA82");
        }
    }
}
