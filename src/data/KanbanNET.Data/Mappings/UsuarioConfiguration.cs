using KanbanNET.Services.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace KanbanNET.Data.Mappings
{
    internal class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(e => e.UsuarioId);

            builder.Property(e => e.Apelido)
                .IsRequired()
                .HasColumnType("nvarchar(20)");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(60)");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("nvarchar(320)");
            builder.HasIndex(e => e.Email).IsUnique();

            builder
                .HasMany(e => e.Boards)
                .WithMany(e => e.Usuarios)
                .UsingEntity<BoardUsuario>();

            builder
                .HasMany(e => e.CardComentarios)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId);
        }
    }
}
