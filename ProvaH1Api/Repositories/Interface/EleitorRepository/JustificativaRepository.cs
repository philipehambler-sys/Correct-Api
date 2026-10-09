using ProvaH1Api.Models;

namespace ProvaH1Api.Repositories.Interfaces;

public interface IJustificativaRepository
{
    void Adicionar(Justificativa justificativa);
    IEnumerable<Justificativa> ObterPorEleitor(int CPF);
}