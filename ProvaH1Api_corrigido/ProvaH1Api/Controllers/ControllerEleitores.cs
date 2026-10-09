using ProvaH1Api.Models;
using ProvaH1Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProvaH1Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EleitorController : ControllerBase
{
    private readonly IEleitorRepository _eleitorRepository;

    public EleitorController(IEleitorRepository eleitorRepository)
    {
        _eleitorRepository = eleitorRepository;
    }

    [HttpPost]
    public IActionResult Cadastrar([FromBody] Eleitor eleitor)
    {
        if (_eleitorRepository.ExistePorCPF(eleitor.CPF))
        {
            return Conflict(new { mensagem = $"Já existe um eleitor com o CPF {eleitor.CPF}." });
        }

        _eleitorRepository.Adicionar(eleitor);
        return StatusCode(StatusCodes.Status201Created, eleitor);
    }

    [HttpGet]
    public IActionResult Listar()
    {
        return Ok(_eleitorRepository.ObterTodos());
    }
}