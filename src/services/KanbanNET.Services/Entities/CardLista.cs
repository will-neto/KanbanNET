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
        public CardLista(Guid id, string titulo, short ordem)
        {
            Id = id;
            Titulo = titulo;
            Ordem = ordem;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; } = null!;
        public short Ordem { get; set; }
        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
