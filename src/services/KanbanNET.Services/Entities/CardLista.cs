using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanNET.Services.Entities
{
    public class CardLista
    {

        public Guid CardListaId { get; private set; }
        public string Titulo { get; private set; } = null!;
        public short Ordem { get; private set; }
        public Guid BoardId { get; private set; }

        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
