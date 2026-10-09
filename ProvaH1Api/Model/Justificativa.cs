using System.ComponentModel.DataAnnotations;

namespace ProvaH1Api.Models;

public class Justificativa
{
    [Required(ErrorMessage = "A justificativa é obrigatória!")]
    public string Justificativa { get; set; } = string.Empty;

}