namespace KanbanNET.Services.Entities
{
    public class Card
    {   
        public Guid CardId { get; private set; }
        public string Titulo { get; private set; } = null!;
        public string Descricao { get; private set; } = null!;
        public short Ordem { get; private set; }
        public Guid CardListaId { get; private set; }

        public ICollection<CardComentario> Comentarios { get; set; } = new List<CardComentario>();
    }
}
