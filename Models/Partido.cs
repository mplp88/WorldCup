using System.ComponentModel.DataAnnotations;

namespace WorldCup.Models;

public class Partido
{
    public int Id { get; set; }
    [Required]
    public Pais Pais1 { get; set; } = new Pais();
    [Required]
    public Pais Pais2 {get;set;} = new Pais();
    public DateTime Fecha { get; set; }
}