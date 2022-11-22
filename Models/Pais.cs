using System.ComponentModel.DataAnnotations;

namespace WorldCup.Models;

public class Pais
{
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; } = string.Empty;
    public virtual IEnumerable<Jugador> Jugadores { get; set; } = new HashSet<Jugador>();
}
