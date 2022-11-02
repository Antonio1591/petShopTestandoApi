using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[NotMapped]
public class CidadeInputModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string UF { get; set; }
}

