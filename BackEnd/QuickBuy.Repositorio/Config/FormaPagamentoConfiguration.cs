using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder
                .ToTable("FormaPagamento");

            builder
                .HasKey(fp => fp.Id);

            builder
                .Property(fp => fp.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
