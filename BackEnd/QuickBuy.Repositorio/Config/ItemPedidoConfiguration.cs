using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder
                .ToTable("ItemPedido");

            builder
                .HasKey(ip => ip.Id);

            builder
                .Property(ip => ip.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
