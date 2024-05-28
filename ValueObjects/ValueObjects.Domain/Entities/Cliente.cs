using ValueObjects.Domain.Primitives;
using ValueObjects.Domain.ValueObjects;

namespace ValueObjects.Domain.Entities;

public sealed class Cliente
    (Guid id, string nome, EnderecoEmail email, DateTime dataNascimento, string telefone) : Entity(id)
{
    public string Nome { get; set; } = nome;

    public EnderecoEmail Email { get; set; } = email;

    public DateTime DataNascimento { get; set; } = dataNascimento;

    public string Telefone { get; set; } = telefone;
}
