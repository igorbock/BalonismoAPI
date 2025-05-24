namespace BalonismoLIB.Modelos;

public class Balonista
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int IdEquipe { get; set; }
    public Equipe Equipe { get; set; }
}
