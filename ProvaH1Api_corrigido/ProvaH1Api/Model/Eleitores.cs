using System.ComponentModel.DataAnnotations;

namespace ProvaH1Api.Models;

public class Eleitor
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "CPF é inválido.")]
    public string CPF { get; set; } = string.Empty;

    [Required(ErrorMessage = "O UF é obrigatório.")]
    [RegularExpression("^(MG|SP|RJ|ES)$", ErrorMessage = "O UF deve ser MG, SP, RJ ou ES.")]
    public string UF { get; set; } = string.Empty;

    [Required(ErrorMessage = "O título de eleitor é obrigatório.")]
    [StringLength(50, ErrorMessage = "O título de eleitor deve ter no máximo 50 caracteres.")]
    public string Numero { get; set; } = string.Empty;
}
