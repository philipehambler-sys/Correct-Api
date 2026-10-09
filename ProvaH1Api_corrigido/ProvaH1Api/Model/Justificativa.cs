using System.ComponentModel.DataAnnotations;

namespace ProvaH1Api.Models;

public class Justificativa
{
    [Required(ErrorMessage = "O CPF é obrigatório.")]
    public string CPF { get; set; } = string.Empty;

    [Required(ErrorMessage = "A justificativa é obrigatória!")]
    public string Texto { get; set; } = string.Empty;
}
