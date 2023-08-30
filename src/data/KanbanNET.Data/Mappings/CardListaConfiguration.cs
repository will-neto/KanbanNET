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
    internal class CardListaConfiguration : IEntityTypeConfiguration<CardLista>
    {
        public void Configure(EntityTypeBuilder<CardLista> builder)
        {

            builder.ToTable("CardListas");

            builder.Property(e => e.BoardId)
                .IsRequired();

            builder.HasKey(e => e.CardListaId);

            builder.Property(e => e.Titulo)
                .HasColumnType("nvarchar(150)");

            builder.Property(e => e.Ordem)
                .HasColumnType("smallint");

            builder
                .HasMany(e => e.Cards)
                .WithOne(e => e.CardLista)
                .HasForeignKey(e => e.CardListaId);
        }
    }
}
