using ProvaH1Api.Models;
using ProvaH1Api.Repositories.Interfaces;

namespace ProvaH1Api.Repositories;

public class EleitorRepository : IEleitorRepository
{
    private readonly List<Eleitor> _eleitores = new();

    public void Adicionar(Eleitor eleitor)
    {
        _eleitores.Add(eleitor);
    }

    public IEnumerable<Eleitor> ObterTodos()
    {
        return _eleitores;
    }

    public bool ExistePorCPF(string cpf)
    {
        return _eleitores.Any(e => e.CPF == cpf);
    }
}
