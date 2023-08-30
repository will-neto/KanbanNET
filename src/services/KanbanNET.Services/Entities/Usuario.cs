namespace KanbanNET.Services.Entities
{
    public class Usuario
    {

        public Guid UsuarioId { get; private set; }
        public string Nome { get; private set; } = null!;
        public string Email { get; private set; } = null!; //TODO: E-mail tem que ser unico
        public string Apelido { get; private set; } = null!;
        public DateTime DataNascimento { get; private set; } = new DateTime(1900, 01, 01);
        public ICollection<Board> Boards { get; private set; } = new List<Board>();
        public ICollection<BoardUsuario> BoardUsuario { get; private set; } = new List<BoardUsuario>();
        public ICollection<CardComentario> CardComentarios { get; private set; } = new List<CardComentario>();
    }
}
