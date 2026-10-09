using ProvaH1Api.Models;
using ProvaH1Api.Repositories.Interfaces;

namespace ProvaH1Api.Repositories;

public class JustificativaRepository : IJustificativaRepository
{
    private readonly List<Justificativa> _justificativa = new();

    public void Adicionar(Justificativa justificativa)
    {
        _justificativa.Add(justificativa);
    }
}