using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanNET.Services.Entities
{
    public class CardComentario
    {
        public Guid CardComentarioId { get; private set; }
        public string Comentario { get; private set; } = null!;
        public DateTime DataCriacao { get; private set; }

        public Guid CardId { get; private set; }
        public Guid UsuarioId { get; private set; }

        public Usuario Usuario { get; set; } = null!;
    }
}
