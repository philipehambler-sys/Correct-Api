using ProvaH1Api.Models;
using ProvaH1Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProvaH1Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JustificativaController : ControllerBase
{
    private readonly IJustificativaRepository _justificativaRepository;
    private readonly IEleitorRepository _eleitorRepository;

    public VotosController(IJustificativaRepository justificativaRepository, IEleitorRepository eleitorRepository)
    {
        _justificativaRepository = justificativaRepository;
        _eleitorRepository = eleitorRepository;
    }

    [HttpPost]
    public IActionResult Registrar([FromBody] Justificativa justificativa)
    {
        if (!_eleitorRepository.ExistePorCPF(cpf))
        {
            return NotFound(new { mensagem = $"Eleitor {cpf} não encontrado." });
        }

        _justificativaRepository.Adicionar(justificativa);
        return StatusCode(StatusCodes.Status201Created, justificativa);
    }

    [HttpGet("eleitor/{numero:int}")]
    public IActionResult ConsultarPorCandidato(int cpf)
    {
        return Ok(_justificativaRepository.ObterPorCPF(CPF));
    }
}