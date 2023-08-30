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
    internal class BoardConfiguration : IEntityTypeConfiguration<Board>
    {

        public void Configure(EntityTypeBuilder<Board> builder)
        {

            builder.ToTable("Boards");

            builder.HasKey(e => e.BoardId);

            builder.Property(e => e.Ativo).IsRequired();

            builder.Property(e => e.Descricao)
                .HasColumnType("nvarchar(1024)");

            builder.Property(e => e.Titulo)
                .HasColumnType("nvarchar(150)");

            builder
                .HasMany(e => e.CardListas)
                .WithOne(e => e.Board)
                .HasForeignKey(e => e.BoardId);
        }

    }
}
