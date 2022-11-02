using petShopTestandoApi.Model.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[NotMapped]
public class PessoaInputModel
{
    public PessoaInputModel(string nome, Cidade cidade, DateTime dataNascimento)
    {
        Nome = nome;
        Cidade = cidade;
        DataNascimento = dataNascimento;
    }

    [Key]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public Cidade Cidade { get; set; }
    [Required]
    public DateTime DataNascimento { get; set; }
}