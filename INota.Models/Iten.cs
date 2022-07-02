namespace INota.Models
public class Iten
{
    public string cfop { get; set; }
    public string codigo { get; set; }
    public string descricao { get; set; }
    public string sku { get; set; }
    public string ncm { get; set; }
    public string cest { get; set; }
    public int quantidade { get; set; }
    public string unidadeMedida { get; set; }
    public int valorUnitario { get; set; }
    public Impostos impostos { get; set; }
    public string informacoesAdicionais { get; set; }
}
