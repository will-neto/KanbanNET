namespace KanbanNET.Services.Entities
{
    public class Usuario
    {

        public Usuario(Guid id, string nome, string email, string apelido, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Apelido = apelido;
            DataNascimento = dataNascimento;
        }

        public Guid Id { get; init; }
        public string Nome { get; private set; } = null!;
        public string Email { get; private set; } = null!; //TODO: E-mail tem que ser unico
        public string Apelido { get; private set; } = null!;
        public DateTime DataNascimento { get; private set; } = new DateTime(1900, 01, 01);

    }
}
