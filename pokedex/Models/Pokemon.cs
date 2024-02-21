namespace pokedex.Models;

public class Pokemon
{
    public int Numero  { get; set; }
    public string Nome { get; set; }
    public string descricao { get; set; }
    public string Especie { get; set; }
    public List<string> Tipo { get; set; }
    public double altura { get; set; }
    public string imagem { get; set; }
}
