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

    public JustificativaController(IJustificativaRepository justificativaRepository, IEleitorRepository eleitorRepository)
    {
        _justificativaRepository = justificativaRepository;
        _eleitorRepository = eleitorRepository;
    }

    [HttpPost]
    public IActionResult Registrar([FromBody] Justificativa justificativa)
    {
        if (!_eleitorRepository.ExistePorCPF(justificativa.CPF))
        {
            return NotFound(new { mensagem = $"Eleitor {justificativa.CPF} não encontrado." });
        }

        _justificativaRepository.Adicionar(justificativa);
        return StatusCode(StatusCodes.Status201Created, justificativa);
    }

    [HttpGet]
    public IActionResult Listar()
    {
        return Ok(_justificativaRepository.ObterTodas());
    }

    [HttpGet("eleitor/{cpf}")]
    public IActionResult ConsultarPorEleitor(string cpf)
    {
        return Ok(_justificativaRepository.ObterPorCPF(cpf));
    }
}
