using System.ComponentModel.DataAnnotations;

namespace WorldCup.Models;

public class Grupo
{
    public int Id { get; set; }
    [Required]
    public char Letra { get; set; }
    [Required]
    public virtual Pais Pais1 { get; set; } = new Pais();
    [Required]
    public virtual Pais Pais2 { get; set; } = new Pais();
    [Required]
    public virtual Pais Pais3 { get; set; } = new Pais();
    [Required]
    public virtual Pais Pais4 { get; set; } = new Pais();
}