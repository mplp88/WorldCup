namespace WorldCup.Models;

public class Jugador
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public int Edad { get; set; }
    public int PaisId { get; set; }
    public Pais Pais { get; set; } = new Pais();
    public int NumeroCamiseta { get; set; }

}