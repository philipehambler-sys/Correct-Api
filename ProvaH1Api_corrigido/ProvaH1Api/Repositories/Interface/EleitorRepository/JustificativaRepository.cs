using ProvaH1Api.Models;
using ProvaH1Api.Repositories.Interfaces;

namespace ProvaH1Api.Repositories;

public class JustificativaRepository : IJustificativaRepository
{
    private readonly List<Justificativa> _justificativas = new();

    public void Adicionar(Justificativa justificativa)
    {
        _justificativas.Add(justificativa);
    }

    public IEnumerable<Justificativa> ObterTodas()
    {
        return _justificativas;
    }

    public IEnumerable<Justificativa> ObterPorCPF(string cpf)
    {
        return _justificativas.Where(j => j.CPF == cpf);
    }
}
