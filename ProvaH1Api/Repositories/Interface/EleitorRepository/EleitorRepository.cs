using ProvaH1Api.Models;
using ProvaH1Api.Repositories.Interfaces;

namespace ProvaH1Api.Repositories;

public class EleitorRepository : IEleitorRepository
{
    private readonly List<Eleitor> _eleitor = new();

    public void Adicionar(Eleitor eleitor)
    {
        _eleitor.Add(eleitor);
    }

    public IEnumerable<Eleitor> ObterTodos()
    {
        return _eleitor;
    }

    public bool ExistePorCPF(int CPF)
    {
        return _eleitor.Any(c => c.CPF == cpf);
    }
}