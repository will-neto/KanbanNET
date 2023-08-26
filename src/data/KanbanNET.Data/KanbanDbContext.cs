using KanbanNET.Services.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Tokens;

namespace KanbanNET.Data
{
    public class KanbanDbContext : DbContext
    {
        public KanbanDbContext(DbContextOptions<KanbanDbContext> options) : base(options)
        {
            
        }
        public DbSet<Board> Boards { get; set; } = null!;
        //public DbSet<BoardUsuario> BoardUsuarios { get; set; } = null!;
        public DbSet<Card> Cards { get; set; } = null!;
        public DbSet<CardLista> CardListas { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<CardComentario> CardComentarios { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KanbanDbContext).Assembly);
        }
    }
}