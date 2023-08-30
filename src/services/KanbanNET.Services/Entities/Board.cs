using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanNET.Services.Entities
{
    public class Board
    {
        public Guid BoardId { get; private set; }
        public string Titulo { get; private set; } = null!;
        public string Descricao { get; private set; } = null!;
        public bool Ativo { get; private set; }
        public ICollection<Usuario> Usuarios { get; private set; } = new List<Usuario>();
        public ICollection<CardLista> CardListas { get; private set; } = new List<CardLista>();
        public ICollection<BoardUsuario> BoardsUsuarios { get; private set; } = new List<BoardUsuario>();
    }
}
