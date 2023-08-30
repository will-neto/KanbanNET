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
    internal class CardComentarioConfiguration : IEntityTypeConfiguration<CardComentario>
    {

        public void Configure(EntityTypeBuilder<CardComentario> builder)
        {

            builder.ToTable("CardComentarios");

            builder.HasKey(e => e.CardComentarioId);

            builder.Property(e => e.Comentario)
                .HasColumnType("ntext")
                .IsRequired();

            builder.Property(e => e.DataCriacao)
                .HasDefaultValue(new DateTime());

        }
    }
}
