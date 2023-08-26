using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanNET.Services.Entities
{
    public class BoardUsuario
    {
        public Guid UsuarioId { get; private set; }
        public Guid BoardId { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}
