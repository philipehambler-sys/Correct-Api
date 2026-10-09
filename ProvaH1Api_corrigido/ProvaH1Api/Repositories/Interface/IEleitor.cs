using ProvaH1Api.Models;

namespace ProvaH1Api.Repositories.Interfaces;

public interface IEleitorRepository
{
    void Adicionar(Eleitor eleitor);
    IEnumerable<Eleitor> ObterTodos();
    bool ExistePorCPF(string cpf);
}
