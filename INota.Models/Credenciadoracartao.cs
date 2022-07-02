namespace INota.Models 
{
    public class Credenciadoracartao
    {
        public string tipoIntegracaoPagamento { get; set; }
        public string cnpjCredenciadoraCartao { get; set; }
        public string bandeira { get; set; }
        public string autorizacao { get; set; }
    }
}
