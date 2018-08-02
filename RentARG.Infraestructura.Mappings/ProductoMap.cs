using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentARG.Domain;

namespace RentARG.Infraestructura.Mappings
{
    public class ProductoMap : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Nombre)
                .HasColumnType("varchar(150)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Descripcion)
                .HasColumnType("varchar(2000)")
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}
