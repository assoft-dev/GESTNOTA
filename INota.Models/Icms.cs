namespace INota.Models
public class Icms
{
    public string situacaoTributaria { get; set; }
    public int origem { get; set; }
    public int aliquota { get; set; }
    public int baseCalculo { get; set; }
    public int modalidadeBaseCalculo { get; set; }
    public int percentualReducaoBaseCalculo { get; set; }
    public int baseCalculoST { get; set; }
    public int aliquotaST { get; set; }
    public int modalidadeBaseCalculoST { get; set; }
    public int percentualReducaoBaseCalculoST { get; set; }
    public int percentualMargemValorAdicionadoST { get; set; }
}
