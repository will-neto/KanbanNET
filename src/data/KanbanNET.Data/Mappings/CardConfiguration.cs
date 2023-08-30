using KanbanNET.Services.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanNET.Data.Mappings
{
    internal class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Cards");

            builder.HasKey(e => e.CardId);

            builder.Property(e => e.Titulo)
                .HasColumnType("nvarchar(150)");

            builder.Property(e => e.Descricao)
                .HasColumnType("nvarchar(1024)");

            builder.Property(e => e.Ordem)
                .HasColumnType("smallint");

            builder
                .HasMany(e => e.Comentarios)
                .WithOne(e => e.Card)
                .HasForeignKey(e => e.CardId);
        }
    }
}
